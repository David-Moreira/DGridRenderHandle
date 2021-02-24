using Blazorise.DataGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGridRenderHandle.Shared
{
    public partial class DataGridWrapper<TItem> : DataGrid<TItem>
    {

        public DataGridWrapper() : base()
        {
            base.PageSize = 20;
        }
    }
}
