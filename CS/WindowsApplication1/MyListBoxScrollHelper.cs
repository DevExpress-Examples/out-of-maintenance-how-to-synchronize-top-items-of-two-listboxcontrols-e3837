using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Reflection;

namespace WindowsApplication1
{
    [System.ComponentModel.DesignerCategory("")]
    public class MyListBoxScrollHelper : Component
    {

        public event ScrollEventHandler HScroll;
        public event ScrollEventHandler VScroll;

        #region OnOnHScroll
        /// <summary>
        /// Triggers the OnHScroll event.
        /// </summary>
        public virtual void OnHScroll(object sender, ScrollEventArgs ea)
        {
            if (HScroll != null)
                HScroll(sender, ea);
        }
        #endregion
        #region OnOnVScroll
        /// <summary>
        /// Triggers the OnVScroll event.
        /// </summary>
        public virtual void OnVScroll(object sender, ScrollEventArgs ea)
        {
            if (VScroll != null)
                VScroll(sender, ea);
        }
        #endregion


        public MyListBoxScrollHelper()
        {

        }

        // Fields...
        private ListBoxControl _ListBox;

        public ListBoxControl ListBox
        {
            get { return _ListBox; }
            set
            {
                ListBoxControl prevValue = _ListBox;
                _ListBox = value;
                OnListBoxChanged(prevValue, value);
            }
        }
        private void OnListBoxChanged(ListBoxControl prevValue, ListBoxControl newValue)
        {
            if (prevValue != null)
                UnSubscribeEvents(prevValue);
            if (newValue != null)
                SubscribeEvents(newValue);
        }


        private void UnSubscribeEvents(ListBoxControl prevValue)
        {
            ListBoxScrollInfo si = GetScrollInfo(prevValue);
            if (si != null)
            {
                si.VScroll_Scroll += MyListBoxScrollHelper_VScroll_Scroll;
                si.HScroll_Scroll -= MyListBoxScrollHelper_HScroll_Scroll;
            }
        }
        private static ListBoxScrollInfo GetScrollInfo(ListBoxControl newValue)
        {
            PropertyInfo pi = newValue.GetType().GetProperty("ScrollInfo", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return pi.GetValue(newValue, null) as ListBoxScrollInfo;
        }
        private void SubscribeEvents(ListBoxControl newValue)
        {
            ListBoxScrollInfo si = GetScrollInfo(newValue);
            if (si != null)
            {
                si.VScroll_Scroll += MyListBoxScrollHelper_VScroll_Scroll;
                si.HScroll_Scroll += MyListBoxScrollHelper_HScroll_Scroll;
            }
        }

        void MyListBoxScrollHelper_HScroll_Scroll(object sender, ScrollEventArgs e)
        {
            OnHScroll(ListBox, e);
        }

        void MyListBoxScrollHelper_VScroll_Scroll(object sender, ScrollEventArgs e)
        {
            OnVScroll(ListBox, e);
        }


    }
}
