using APIAnimeApp.Model;

namespace APIAnimeApp.Interface
{
	public interface IStoryRepository
	{
		public ICollection<Story> getAll();
		public Story getById(int id);
		public bool isExist(int id);
		public ICollection<Story> getByName(string name);
		public ICollection<Story> getByCategory(int categoryId);
	}
}
