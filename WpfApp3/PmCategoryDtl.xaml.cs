﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// PmCategoryDtl.xaml 的交互逻辑
    /// </summary>
    public partial class PmCategoryDtl : UserControl
    {
        private NodeX temp;
        private bool v;

        public PmCategoryDtl()
        {
            InitializeComponent();
        }
        public PmCategoryDtl(NodeX temp, bool isAdd = true)
        {
            this.temp = temp;
            this.v = v;
        }

        public Action<object, NodeX> SaveEvent { get; internal set; }
    }
}
