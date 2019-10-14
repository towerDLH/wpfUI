using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// WinDatagrid.xaml 的交互逻辑
    /// </summary>
    public partial class WinDatagrid : Window
    {
        public WinDatagrid()
        {
            InitializeComponent();
            BuildDG2();
            BuildDG21();
        }

        void BuildDG2()
        {
            for (int i = 0; i < 4; i++)
            {
                ColumnDefinition column1 = new ColumnDefinition();
                column1.Width = GridLength.Auto;
                this.GridHs.ColumnDefinitions.Add(column1);

                ColumnDefinition column = new ColumnDefinition();
                column.Width = new GridLength(1);
                this.GridHs.ColumnDefinitions.Add(column);
            }

            for (int i = 0; i < 3; i++)
            {
                this.GridHs.RowDefinitions.Add(new RowDefinition());
                RowDefinition column = new RowDefinition();
                column.Height = new GridLength(1);
                this.GridHs.RowDefinitions.Add(column);
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0 && j == 2)
                    {
                        continue;
                    }
                    UniformGrid gridTitle = new UniformGrid();

                    Border b = new Border();
                    b.VerticalAlignment = VerticalAlignment.Stretch;
                    b.HorizontalAlignment = HorizontalAlignment.Stretch;
                    b.Name = "Grid" + i + j;

                    Pen p = new Pen();

                    b.BorderBrush = new SolidColorBrush(Colors.Green);
                    b.BorderThickness = new System.Windows.Thickness(2);



                    TextBlock tbxTitleChinese = new TextBlock();

                    b.Child = tbxTitleChinese;

                    tbxTitleChinese.Text = "语文" + i + j;
                    tbxTitleChinese.Width = 60;
                    tbxTitleChinese.Height = 20;

                    gridTitle.Children.Add(b);

                    gridTitle.SetValue(Grid.RowProperty, i * 2);
                    gridTitle.SetValue(Grid.ColumnProperty, j * 2);
                    this.GridHs.Children.Add(gridTitle);

                    if (i == 0 && j == 1)
                    {
                        Grid.SetColumnSpan(gridTitle, 3);
                        b.Width = 100;
                    }

                    if (i == 2)
                    {
                        Binding bd = new Binding();
                        bd.Path = new System.Windows.PropertyPath("Width");
                        bd.ElementName = @"行" + i;
                        BindingOperations.SetBinding(gridTitle, WidthProperty, bd);
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                GridSplitter gSp = new GridSplitter();
                gSp.Background = new SolidColorBrush(Colors.Green);
                gSp.HorizontalAlignment = HorizontalAlignment.Stretch;
                gSp.Width = 1;

                if (i == 1)
                {
                    gSp.SetValue(Grid.RowProperty, 1);
                }
                else
                {
                    gSp.SetValue(Grid.RowProperty, 0);
                }
                gSp.SetValue(Grid.ColumnProperty, i * 2 + 1);
                this.GridHs.Children.Add(gSp);
                Grid.SetRowSpan(gSp, 6);
            }

        }
        public ObservableCollection<ObservableCollection<string>> datas2 = new ObservableCollection<ObservableCollection<string>>();
        void BuildDG21()
        {
            for (int i = 0; i < 10; i++)
            {
                ObservableCollection<string> columnsList = new ObservableCollection<string>();
                for (int j = 0; j < 4; j++)
                {
                    columnsList.Add((i + j + 3).ToString());
                }
                datas2.Add(columnsList);
            }

            for (int i = 0; i < 4; i++)
            {
                DataGridTextColumn dgColumn = new DataGridTextColumn();
                dgColumn.Header = @"行" + i;
                dgColumn.SetValue(NameProperty, @"行" + i);
                this.DataGridHs.Columns.Add(dgColumn);

                MultiBinding mbd = new MultiBinding();
                Binding bd1 = new Binding("[" + i + "]");


                Binding bd2 = new Binding();
                bd2.Path = new System.Windows.PropertyPath("ActualWidth");
                bd2.Source = LogicalTreeHelper.FindLogicalNode(this.GridHs, "Grid2" + i);

                dgColumn.Binding = bd1;
                BindingOperations.SetBinding(dgColumn, DataGridTextColumn.WidthProperty, bd2);
            }

            this.DataGridHs.DataContext = datas2;
        }
    }
}
