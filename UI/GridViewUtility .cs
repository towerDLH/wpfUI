using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace UI
{
    public class GridViewUtility : GridView
    {
        #region 附加属性
        public static readonly DependencyProperty ColumnObjectCollectionProperty =
            DependencyProperty.RegisterAttached("ColumnObjectCollection", typeof(ColumnObjectCollections), typeof(GridView),
            new PropertyMetadata(GridViewUtility.OnColumnObjectCollectionChanged));

        static void OnColumnObjectCollectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ColumnObjectCollections col = e.NewValue as ColumnObjectCollections;
            if (col != null)
            {
                col.GViewCollection = ((GridView)d).Columns;
                int index = 0;
                col.GViewAllCollection = new List<ColumnObject>();
                foreach (GridViewColumn gc in col.GViewCollection)
                {
                    col.GViewAllCollection.Add(new ColumnObject(index, true, gc, col));
                    index++;
                }

            }

        }

        public static ColumnObjectCollections GetColumnObjectCollection(GridView gridview)
        {
            return (ColumnObjectCollections)gridview.GetValue(ColumnObjectCollectionProperty);
        }

        public static void SetColumnObjectCollection(GridView gridew, ColumnObjectCollections collection)
        {
            gridew.SetValue(ColumnObjectCollectionProperty, collection);
        }


        #endregion      
    }
    public class ColumnObjectCollections
    {
        public GridViewColumnCollection GViewCollection
        {
            get;
            set;
        }
        public List<ColumnObject> GViewAllCollection
        {
            get;
            set;
        }
        public void SetColumnVisable(int index, bool isVisable)
        {
            if (index >= 0 && index < GViewAllCollection.Count)
            {
                GViewAllCollection[index].IsVisable = isVisable;
            }
        }

        public bool IsColumnVisable(int index)
        {
            if (index < 0 || index >= GViewAllCollection.Count)
            {
                return false;
            }
            return GViewAllCollection[index].IsVisable;
        }
    }
    public class ColumnObject
    {
        private int index;
        private ColumnObjectCollections col;
        private GridViewColumn column;
        private bool isVisable;
        public bool IsVisable
        {
            get
            {
                return isVisable;
            }
            set
            {
                isVisable = value;
                SetVisable(isVisable);
            }

        }
        public string Header
        {
            get
            {
                return this.column.Header.ToString();
            }
        }
        public ColumnObject(int index, bool isVisable, GridViewColumn column, ColumnObjectCollections col)
        {
            this.index = index;
            this.IsVisable = true;
            this.col = col;
            this.column = column;
        }
        private void SetVisable(bool isVisable)
        {
            if (isVisable)
            {
                if (!this.IsVisable)
                {
                    int index = this.index;
                    this.col.GViewAllCollection[index].isVisable = true;
                    for (int i = index + 1; i < this.col.GViewAllCollection.Count; i++)
                    {
                        if (this.col.GViewAllCollection[i].isVisable)
                        {
                            index = this.col.GViewAllCollection[i].index - 1;
                            break;
                        }
                    }
                    this.col.GViewCollection.Insert(index, this.column);
                }
            }
            else
            {
                this.col.GViewCollection.Remove(this.column);
            }
        }
    }
}