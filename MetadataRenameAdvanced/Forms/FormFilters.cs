﻿using System;
using System.Windows.Forms;

namespace MetadataRenameAdvanced {
    public partial class FormFilters : Form {
        //public FormFilters(FilterList filterList) {
        //    InitializeComponent();

        //    SetFilters(filterList);
        //}

        //private void SetFilters(FilterList filterList) {
        //    if (filterList != null) {
        //        //Set default filters
        //        foreach (DefaultFilters filter in filterList.defaultFilters) {
        //            chklstComFilters.SetItemChecked((int)filter, true);
        //        }

        //        //Set custom filters
        //        foreach (string[] filter in filterList.customFilters) {
        //            gvFilters.Rows.Add(filter[0], filter[1]);
        //        }
        //    }
        //}

        private void btnOk_Click(object sender, EventArgs e) {
            //    //Create and populate default filters list
            //    List<DefaultFilters> defaultFilters = new List<DefaultFilters>();

            //    for (int i = 0; i < chklstComFilters.Items.Count; i++) {
            //        if (chklstComFilters.GetItemCheckState(i) == CheckState.Checked) {
            //            defaultFilters.Add((DefaultFilters)i);
            //        }
            //}

            //    //Create and populate custom filters list
            //    List<string[]> customFilters = new List<string[]>();

            //    foreach (DataGridViewRow row in gvFilters.Rows) {
            //        if (row.Index < gvFilters.Rows.Count - 1) {
            //            string cell0 = (row.Cells[0].Value != null) ? row.Cells[0].Value.ToString() : "";
            //            string cell1 = (row.Cells[1].Value != null) ? row.Cells[1].Value.ToString() : "";

            //            customFilters.Add(new string[] { cell0, cell1 });
            //        }
            //    }
            //    FilterList filterList = new FilterList(defaultFilters, customFilters);

            //    //If both filter lists are empty return null otherwise return filter list container
            //    this.Tag = (defaultFilters.Count == 0 && customFilters.Count == 0) ? null : filterList;

            //    //Set dialog result to return to main form
            //    this.DialogResult = DialogResult.OK;
        }
    }
}
