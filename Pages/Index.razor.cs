using Cigars.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using SQLitePCL;

namespace Cigars.Pages
{
	public partial class Index
	{
		public bool ShowCreate { get; set; }
		public bool ShowEdit { get; set; }
		public int EditingId { get; set; }
		private CigarDataContext? _context;
		public Cigar? NewCigar { get; set; }
		public Cigar? CigarToUpdate { get; set; }
		public List<Cigar>? OurCigars { get; set; }
        public string BrandSearchText { get; set; }


        protected override async Task OnInitializedAsync()
		{
			ShowCreate = false;
			await ShowCigar();
		}



		// Update section

		public async Task ShowEditForm(Cigar ourCigar)
		{
			_context ??= await CigarDataContextFactory.CreateDbContextAsync();

			if (_context is not null)
			{
				CigarToUpdate = _context.Cigar.FirstOrDefault(x => x.Id == ourCigar.Id);
				ShowEdit = true;
				EditingId = ourCigar.Id;
			}
		}

		public async Task UpdateCigar()
		{
			_context ??= await CigarDataContextFactory.CreateDbContextAsync();

			if (_context is not null)
			{
				if (CigarToUpdate is not null) _context.Cigar.Update(CigarToUpdate);
				await _context.SaveChangesAsync();
			}
			ShowEdit = false;
		}


		// Read section
		public async Task ShowCigar()
		{
			_context ??= await CigarDataContextFactory.CreateDbContextAsync();

			if (_context != null)
			{
				OurCigars = await _context.Cigar.ToListAsync();
			}
		}

		// Create section
		public void ShowCreateForm()
		{
			ShowCreate = true;
			NewCigar = new Cigar();
		}

		public async Task CreateNewCigar()
		{
			_context ??= await CigarDataContextFactory.CreateDbContextAsync();

			if (NewCigar is not null)
			{
				_context?.Cigar.Add(NewCigar);
				_context?.SaveChangesAsync();
			}
			ShowCreate = false;
			await ShowCigar();
		}

		// Delete section

		public async Task DeleteCigar(Cigar ourCigar)
		{
			if (ourCigar != null)
			{
				bool confirmed = await JSRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to delete this cigar?");

				if (confirmed)
				{
					_context ??= await CigarDataContextFactory.CreateDbContextAsync();

					if (_context != null)
					{
						_context.Cigar.Remove(ourCigar);
						await _context.SaveChangesAsync();
						await ShowCigar();
					}
				}
			}
		}

        // Search by brand
        public async Task SearchByBrand()
        {
            _context ??= await CigarDataContextFactory.CreateDbContextAsync();

            if (_context != null && !string.IsNullOrEmpty(BrandSearchText))
            {
                OurCigars = await _context.Cigar.Where(c => c.Brand.Contains(BrandSearchText)).ToListAsync();
            }
        }
    }
}
