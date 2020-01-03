using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.Texture
{
	public interface ITextureProviderSystemAndUser : ITextureProvider
	{
		string GetTexturePathToOpen(string category, string feature);
		string GetTexturePathToDelete(string category, string feature);
		string GetTexturePathToSave(string category, string feature);
		string GetSystemTexturePath(string category, string feature);
		string GetCategoryDirectorySystem(string category);
		string GetCategoryDirectoryUser(string category);
		string GetRootDirectory();
		bool IsSystemCategory(string category);
		bool IsUserCategory(string category);
		bool IsSystemTexture(string category, string feature);
		bool IsUserTexture(string category, string feature);
	}
}
