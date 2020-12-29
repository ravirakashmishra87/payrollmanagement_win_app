using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Security.Cryptography;
using System.Globalization;

namespace PayrollerManager
{
    public partial class BaseForm : Form
    {
        protected Boolean Dirty = false;
        protected Form fListView;
        protected DataGridView DGViewInForm = null;

        public ArrayList SelectedProductlist = new ArrayList();
        public static ArrayList rowToDeleteList = new ArrayList();
        private static int _rowToDelete = -1;
        public static int rowToDelete
        {
            get
            {
                return _rowToDelete;
            }
            set
            {
                _rowToDelete = value;
            }


        }

        public Form ListView
        {
            get
            {
                return fListView;
            }
            set
            {
                fListView = value;
            }
        }

        public BaseForm()
        {
            InitializeComponent();
        }

        #region FUNCTION SETONCHANGEGENERICHANDLER
        protected void SetOnChangeGenericHandler(Control.ControlCollection Controls)
        {
            try
            {
                ContextMenuStrip ContextMenu;

                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox) || c.GetType() == typeof(DateTimePicker) || c.GetType() == typeof(RichTextBox))
                    {
                        c.TextChanged += new EventHandler(this.Generic_TextChanged);
                    }
                    if (c.GetType() == typeof(DataGridView))
                    {
                        ((DataGridView)c).CellValueChanged += new DataGridViewCellEventHandler(this.Generic_CellValueChanged);
                    }

                    if (c.GetType() == typeof(DataGridView))
                    {
                        ContextMenu = new ContextMenuStrip();

                        //ContextMenu.Items.Add("&Fix / Unfix Column", null, new EventHandler(ContextMenu_FixUnfix));
                        ContextMenu.Items.Add("&Best Fit", null, new EventHandler(ContextMenu_BestFit));
                        ContextMenu.Items.Add("&Auto Fit", null, new EventHandler(ContextMenu_AutoFit));
                        ContextMenu.Items.Add("&Insert", null, new EventHandler(ContextMenu_Insert));
                        ContextMenu.Items.Add("&Delete", null, new EventHandler(ContextMenu_DeleteRow));

                        DGViewInForm = (DataGridView)c;
                        c.ContextMenuStrip = ContextMenu;
                    }
                    SetOnChangeGenericHandler(c.Controls);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }
        #endregion

        #region GENERIC TEXTCHANGED
        public void Generic_TextChanged(object sender, EventArgs e)
        {
            Dirty = true;
        }

        public void Generic_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Dirty = true;
        }
        #endregion

        #region SHOWSELECTED ITEM GRID
        protected void ShowSelectedItemInGrid(ref DataGridView GRVListng, int iColIndex, String SearchText, Control lblLabel)
        {
            GRVListng.ClearSelection();

            lblLabel.Text = "(" + GRVListng.Columns[iColIndex].HeaderText.ToString() + ")";
            GRVListng.CurrentCell.Selected = true;
        }
        #endregion

        private void ContextMenu_FixUnfix(object sender, EventArgs e)
        {
            try
            {
                DataGridView dgControl = (DataGridView)DGViewInForm;
                HandleFixUnFix(dgControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }
        }

        private void HandleFixUnFix(DataGridView DGControl)
        {
            int iColNo = DGControl.SelectedCells[0].ColumnIndex;

            if (DGControl.Columns[iColNo].Frozen == true)
            {
                DGControl.Columns[iColNo].Frozen = false;
                DGControl.Refresh();

                DGControl.Columns[iColNo].HeaderCell.Style.BackColor = Color.FromArgb(174, 174, 174);
            }
            else
            {
                DGControl.Columns[iColNo].Frozen = true;
                DGControl.Refresh();
                DGControl.Columns[iColNo].HeaderCell.Style.BackColor = Color.Red;
            }

            return;
        }

        private void ContextMenu_BestFit(object sender, EventArgs e)
        {
            try
            {
                DataGridView DGControl = (DataGridView)DGViewInForm;
                DGControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGControl.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }

        }

        private void dgContextMenu_Insert(object sender, EventArgs e)
        {
            try
            {
                DataGridView DGControl = (DataGridView)DGViewInForm;
                DGControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGControl.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }

        }

        private void ContextMenu_DeleteRow(object sender, EventArgs e)
        {
            try
            {
                DataGridView DGControl = (DataGridView)DGViewInForm;
                HandleRowDelete(DGControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }

        }

        private void ContextMenu_AutoFit(object sender, EventArgs e)
        {
            try
            {
                DataGridView DGControl = (DataGridView)DGViewInForm;
                DGControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                DGControl.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Cursor = Cursors.Default;
                exceptionlog.HandleException(ex);
            }

        }

        public void displaySuccessMessageBox()
        {
            MessageBox.Show(new Form() { TopMost = true }, "Report printed successfully", "Employee Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //public void FormClosingEvent(object sender, FormClosingEventArgs e)
        //{
        //    try
        //    {
        //        if (Dirty)
        //        {
        //            if (MessageBox.Show("Form has been modified! do you want to close without saving", "Employee Management", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //            {
        //            }
        //            else
        //            {
        //                e.Cancel = true;
        //                this.Activate();
        //            }
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An Error has occurred. Contact Administrator. \nError - " + ex.Message, "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        this.Cursor = Cursors.Default;
        //    }
        //}

        //AS
        virtual public void AssignToDeletedCollection(ArrayList ObjArrayList_ToBeDeleted)
        {

        }

        public string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private void HandleRowDelete(DataGridView DGControl)
        {

            if (DGControl.SelectedRows.Count > 0)
            {   //Save the selected rwo to copy
                if (DGControl.AllowUserToDeleteRows != false)
                {
                    if ((MessageBox.Show("Are You Sure To Delete This Entire Record.", "Employee Management", System.Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes))
                    {
                        DGControl.AllowUserToDeleteRows = true;
                        rowToDeleteList = new ArrayList();
                        for (int r = 0; r < DGControl.SelectedRows.Count; r++)
                        {
                            rowToDeleteList.Add(DGControl.Rows[DGControl.SelectedRows[r].Index].Cells["OBJECT"].Value);
                        }

                        // rowToDeleteList.Reverse();

                        //BEFORE DELETING CALL THIS....
                        AssignToDeletedCollection(rowToDeleteList);

                        for (int p = 0; p < rowToDeleteList.Count; p++)
                        {
                            rowToDeleteList.Clear();

                            for (int r = 0; r < DGControl.SelectedRows.Count; r++)
                            {
                                rowToDeleteList.Add(DGControl.Rows[DGControl.SelectedRows[r].Index].Cells["OBJECT"].Value);
                                p = 0;
                            }

                            BaseForm.rowToDelete = DGControl.SelectedRows[0].Index;

                            int rowCount;
                            rowCount = DGControl.SelectedRows.Count;

                            DGControl.Rows.RemoveAt(DGControl.SelectedRows[0].Index);


                        }

                    }
                }
            }

        }

        private void ContextMenu_Insert(object sender, EventArgs e)
        {
            try
            {
                //ToolStripDropDownItem caller = (ToolStripDropDownItem)sender;
                DataGridView dgControl = (DataGridView)DGViewInForm;

                if (dgControl.SelectedRows.Count != 0)
                {
                    if (dgControl.SelectedRows[0].IsNewRow == true)
                    {
                        MessageBox.Show("No Row Can Be Inserted After This!!", "Employee Management", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        dgControl.Rows.Insert(dgControl.SelectedRows[0].Index + 1);
                        //}
                        IsNewRow = true;// A USER DEFINED PROPERTY....
                    }
                }
                else
                {
                    MessageBox.Show("No Row Selected!!", "Employee Management", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An Error Has Occured......Contact Administrator.....", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static Boolean bInsert = false;
        public static Boolean IsNewRow
        {
            get
            {
                return bInsert;
            }
            set
            {
                bInsert = value;
            }

        }



    }

    static class DateTimeExtensions
    {
        public static string ToMonthName(this DateTime dateTime)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateTime.Month).ToUpper();
        }

        public static string ToShortMonthName(this DateTime dateTime)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(dateTime.Month).ToUpper();
        }
    }



}
