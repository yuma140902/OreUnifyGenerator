using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OreUnifyGenerator.Model.ViewData
{
	interface IViewDataProvider<T> where T : IViewData
	{
		void SetData(T data);
		T GetData();
	}
}
