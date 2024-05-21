using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataArray
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            /*
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            */
        }

        private void materialTextBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // بررسی می‌کنیم که کاراکتر وارد شده عدد است یا خیر
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // اگر کاراکتر وارد شده عدد نیست، آن را قبول نمی‌کنیم
                e.Handled = true;
            }
        }

        private void materialButtonAddNumber_Click(object sender, EventArgs e)
        {
            // بررسی اینکه مقدار موجود در materialTextBoxNumber خالی نیست
            if (!string.IsNullOrEmpty(materialTextBoxNumber.Text))
            {
                // تبدیل مقدار وارد شده به عدد
                if (long.TryParse(materialTextBoxNumber.Text, out long numberToAdd))
                {
                    // بررسی اینکه آیا عدد قبلا در لیست وجود دارد یا خیر
                    bool alreadyExists = false;
                    foreach (MaterialListBoxItem item in materialListBoxNumber.Items)
                    {
                        if (long.TryParse(item.Text, out long listItem) && listItem == numberToAdd)
                        {
                            alreadyExists = true;
                            break;
                        }
                    }

                    if (alreadyExists)
                    {
                        MessageBox.Show("The number already exists in the list.");
                    }
                    else
                    {
                        // اضافه کردن عدد وارد شده به materialListBoxNumber
                        materialListBoxNumber.Items.Add(new MaterialListBoxItem(numberToAdd.ToString()));

                        // خالی کردن محتوای materialTextBoxNumber
                        materialTextBoxNumber.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
        }

        private void materialButtonFindNumber_Click(object sender, EventArgs e)
        {
            string numberToFind = materialTextBoxNumber.Text.Trim();

            // اگر آیتمی در materialListBoxTemp انتخاب شده بود
            if (materialListBoxTemp.SelectedItem != null)
            {
                // مقدار عددی متناظر آیتم انتخاب شده در materialListBoxTemp
                string selectedNumber = materialListBoxTemp.SelectedItem.Text;

                // قرار دادن مقدار عددی متناظر در تکست باکس
                materialTextBoxNumber.Text = selectedNumber;

                // جستجو در materialListBoxNumber برای مقدار انتخاب شده
                foreach (MaterialListBoxItem item in materialListBoxNumber.Items)
                {
                    // اگر مقدار متناظر آیتم materialListBoxNumber با مقدار انتخاب شده برابر بود، آن آیتم را انتخاب می‌کنیم
                    if (item.Text == selectedNumber)
                    {
                        materialListBoxNumber.SelectedItem = item;
                        // خالی کردن محتوای materialTextBoxNumber
                        materialTextBoxNumber.Text = "";
                        break;
                    }
                }

                // از حالت انتخاب خارج کردن آیتم انتخاب شده در materialListBoxTemp
                materialListBoxTemp.SelectedItem = null;
            }
            else
            {
                // اگر عددی در تکست باکس وارد شده بود
                if (!string.IsNullOrEmpty(numberToFind))
                {
                    // جستجو در materialListBoxNumber
                    foreach (MaterialListBoxItem item in materialListBoxNumber.Items)
                    {
                        // اگر مقدار متناظر آیتم materialListBoxNumber با مقدار وارد شده برابر بود، آن آیتم را انتخاب می‌کنیم
                        if (item.Text == numberToFind)
                        {
                            materialListBoxNumber.SelectedItem = item;
                            // خالی کردن محتوای materialTextBoxNumber
                            materialTextBoxNumber.Text = "";
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a number in the textbox or select an item in the list.");
                }
            }
        }
        private void materialButtonInsertNumber_Click(object sender, EventArgs e)
        {
            // بررسی اینکه مقدار موجود در materialTextBoxNumber خالی نیست
            if (!string.IsNullOrEmpty(materialTextBoxNumber.Text))
            {
                // تبدیل مقدار وارد شده به عدد
                if (long.TryParse(materialTextBoxNumber.Text, out long numberToInsert))
                {
                    // بررسی اینکه آیا عدد موجود در materialListBoxNumber است
                    if (materialListBoxNumber.Items.Cast<MaterialListBoxItem>().Any(item => long.TryParse(item.Text, out long listItem) && listItem == numberToInsert))
                    {
                        MessageBox.Show("The number already exists in the list.");
                        return;
                    }

                    // اگر هیچ آیتمی انتخاب نشده بود، متوقف شود
                    if (materialListBoxNumber.SelectedItem == null)
                    {
                        MessageBox.Show("Please select an item in the list.");
                        return;
                    }

                    // پیدا کردن ایندکس آیتم انتخاب شده
                    int selectedIndex = materialListBoxNumber.SelectedIndex;

                    // تبدیل عدد به رشته
                    string numberString = numberToInsert.ToString();

                    // تبدیل رشته به MaterialListBoxItem
                    var listBoxItem = new MaterialListBoxItem(numberString);

                    // اضافه کردن عدد وارد شده به لیست در ایندکس مشخص شده
                    materialListBoxNumber.Items.Insert(selectedIndex, listBoxItem);

                    // انتخاب آیتم جدید
                    materialListBoxNumber.SelectedItem = listBoxItem;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
        }

        private void materialButtonReplaceNumber_Click(object sender, EventArgs e)
        {
            // بررسی اینکه مقدار موجود در materialTextBoxNumber خالی نیست
            if (!string.IsNullOrEmpty(materialTextBoxNumber.Text))
            {
                // تبدیل مقدار وارد شده به عدد
                if (long.TryParse(materialTextBoxNumber.Text, out long newNumber))
                {
                    // بررسی اینکه آیا عدد موجود در materialListBoxNumber است
                    if (materialListBoxNumber.Items.Cast<MaterialListBoxItem>().Any(item => long.TryParse(item.Text, out long listItem) && listItem == newNumber))
                    {
                        MessageBox.Show("The number already exists in the list.");
                        return;
                    }

                    // بررسی اینکه آیا آیتمی در لیست انتخاب شده است
                    if (materialListBoxNumber.SelectedItem != null)
                    {
                        // پیدا کردن ایندکس آیتم انتخاب شده
                        int selectedIndex = materialListBoxNumber.SelectedIndex;

                        // حذف آیتم انتخاب شده از لیست
                        materialListBoxNumber.Items.RemoveAt(selectedIndex);

                        // تبدیل عدد جدید به رشته
                        string newNumberString = newNumber.ToString();

                        // تبدیل رشته به MaterialListBoxItem
                        var newNumberItem = new MaterialListBoxItem(newNumberString);

                        // اضافه کردن عدد جدید در جایگاه آیتم حذف شده
                        materialListBoxNumber.Items.Insert(selectedIndex, newNumberItem);

                        // انتخاب آیتم جدید
                        materialListBoxNumber.SelectedItem = newNumberItem;
                    }
                    else
                    {
                        MessageBox.Show("Please select an item in the list.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
        }

        private void materialButtonDeleteNumber_Click(object sender, EventArgs e)
        {
            // بررسی آیا آیتمی در لیست انتخاب شده است
            if (materialListBoxNumber.SelectedItem != null)
            {
                // حذف آیتم انتخاب شده از لیست
                materialListBoxNumber.Items.RemoveAt(materialListBoxNumber.SelectedIndex);

                // از حالت انتخاب درآوردن
                materialListBoxNumber.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Please select an item in the list.");
            }
        }

        private void materialTextBoxNumber_KeyDown(object sender, KeyEventArgs e)
        {
            // بررسی آیا کلید Enter فشرده شده است
            if (e.KeyCode == Keys.Enter)
            {
                // اضافه کردن عدد به لیست
                materialButtonAddNumber.PerformClick();
            }
        }

        private void materialButtonSortLowNumber_Click(object sender, EventArgs e)
        {
            // پاک کردن محتوای materialListBoxTemp
            materialListBoxTemp.Items.Clear();

            // گرفتن آیتم‌ها از materialListBoxNumber و استخراج مقادیر صحیح
            List<long> numbers = new List<long>();
            foreach (object item in materialListBoxNumber.Items)
            {
                // بررسی اینکه آیا آیتم جاری یک MaterialListBoxItem است یا خیر
                if (item is MaterialListBoxItem listBoxItem)
                {
                    // تلاش برای تبدیل متن آیتم به عدد صحیح
                    if (long.TryParse(listBoxItem.Text, out long number))
                    {
                        // اضافه کردن عدد به لیست
                        numbers.Add(number);
                    }
                }
            }

            // حذف اعداد تکراری
            numbers = numbers.Distinct().ToList();

            // مرتب‌سازی اعداد به صورت صعودی
            numbers.Sort();

            // اضافه کردن اعداد مرتب شده به materialListBoxTemp
            foreach (var number in numbers)
            {
                materialListBoxTemp.Items.Add(new MaterialListBoxItem(number.ToString()));
            }
        }

        private void materialButtonSortHighNumber_Click(object sender, EventArgs e)
        {
            // پاک کردن محتوای materialListBoxTemp
            materialListBoxTemp.Items.Clear();

            // گرفتن آیتم‌ها از materialListBoxNumber و استخراج مقادیر صحیح
            List<long> numbers = new List<long>();
            foreach (object item in materialListBoxNumber.Items)
            {
                // بررسی اینکه آیا آیتم جاری یک MaterialListBoxItem است یا خیر
                if (item is MaterialListBoxItem listBoxItem)
                {
                    // تلاش برای تبدیل متن آیتم به عدد صحیح
                    if (long.TryParse(listBoxItem.Text, out long number))
                    {
                        // اضافه کردن عدد به لیست
                        numbers.Add(number);
                    }
                }
            }

            // مرتب‌سازی اعداد به صورت نزولی
            numbers.Sort();
            numbers.Reverse();

            // اضافه کردن اعداد مرتب شده به materialListBoxTemp
            foreach (var number in numbers)
            {
                materialListBoxTemp.Items.Add(new MaterialListBoxItem(number.ToString()));
            }
        }

        private void materialButtonCopyAllNumber_Click(object sender, EventArgs e)
        {
            // پاک کردن محتوای materialListBoxTemp
            materialListBoxTemp.Items.Clear();

            // اضافه کردن تمامی آیتم‌ها از materialListBoxNumber به materialListBoxTemp
            foreach (object item in materialListBoxNumber.Items)
            {
                materialListBoxTemp.Items.Add((MaterialListBoxItem)item);
            }
        }

        private void materialButtonClearAllNumber_Click(object sender, EventArgs e)
        {
            // پاک کردن محتوای materialListBoxNumber
            materialListBoxNumber.Items.Clear();
            // پاک کردن محتوای materialListBoxTemp
            materialListBoxTemp.Items.Clear();
        }

        private void materialTextBoxText_KeyDown(object sender, KeyEventArgs e)
        {
            // بررسی آیا کلید Enter فشرده شده است
            if (e.KeyCode == Keys.Enter)
            {
                // اضافه کردن متن به لیست
                materialButtonAddText.PerformClick();
            }
        }

        private void materialButtonAddText_Click(object sender, EventArgs e)
        {
            // بررسی اینکه مقدار موجود در materialTextBoxText خالی نیست
            if (!string.IsNullOrEmpty(materialTextBoxText.Text))
            {
                // بررسی اینکه آیا متن قبلا در لیست وجود دارد یا خیر
                bool alreadyExists = materialListBoxText.Items.Cast<MaterialListBoxItem>().Any(item => item.Text == materialTextBoxText.Text);

                if (alreadyExists)
                {
                    MessageBox.Show("The text already exists in the list.");
                }
                else
                {
                    // اضافه کردن متن وارد شده به materialListBoxText
                    materialListBoxText.Items.Add(new MaterialListBoxItem(materialTextBoxText.Text));

                    // خالی کردن محتوای materialTextBoxText
                    materialTextBoxText.Text = "";
                }
            }
        }

        private void materialButtonFindText_Click(object sender, EventArgs e)
        {
            string searchText = materialTextBoxText.Text.Trim();

            // اگر آیتمی در لیست موقت انتخاب شده بود
            if (materialListBoxTempText.SelectedIndex != -1)
            {
                // مقدار متناظر آیتم انتخاب شده در materialListBoxTempText
                string selectedText = materialListBoxTempText.SelectedItem.Text;

                // قرار دادن مقدار متناظر در تکست باکس
                materialTextBoxText.Text = selectedText;

                // جستجو در materialListBoxText برای متن انتخاب شده
                foreach (MaterialListBoxItem item in materialListBoxText.Items)
                {
                    // اگر متن متناظر آیتم materialListBoxText با متن انتخاب شده برابر بود، آن آیتم را انتخاب می‌کنیم
                    if (item.Text == selectedText)
                    {
                        materialListBoxText.SelectedItem = item;
                        // خالی کردن محتوای materialTextBoxText
                        materialTextBoxText.Text = "";
                        break;
                    }
                }

                // از حالت انتخاب خارج کردن آیتم انتخاب شده در materialListBoxTempText
                materialListBoxTempText.SelectedIndex = -1;
            }
            else
            {
                // اگر متنی در تکست باکس وارد شده بود
                if (!string.IsNullOrEmpty(searchText))
                {
                    // جستجو در materialListBoxText
                    foreach (MaterialListBoxItem item in materialListBoxText.Items)
                    {
                        // اگر متن متناظر آیتم materialListBoxText با متن جستجویی برابر بود، آن آیتم را انتخاب می‌کنیم
                        if (item.Text == searchText)
                        {
                            materialListBoxText.SelectedItem = item;
                            // خالی کردن محتوای materialTextBoxText
                            materialTextBoxText.Text = "";
                            break;
                        }
                    }

                    // از حالت انتخاب خارج کردن آیتم انتخاب شده در materialListBoxTempText
                    materialListBoxTempText.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Please enter text in the textbox or select an item in the list.");
                }
            }
        }

        private void materialButtonInsertText_Click(object sender, EventArgs e)
        {
            // بررسی اینکه مقدار موجود در materialTextBoxText خالی نیست
            if (!string.IsNullOrEmpty(materialTextBoxText.Text))
            {
                // بررسی اینکه آیا متن موجود در materialListBoxText است
                if (materialListBoxText.Items.Cast<MaterialListBoxItem>().Any(item => item.Text == materialTextBoxText.Text))
                {
                    MessageBox.Show("The text already exists in the list.");
                    return;
                }

                // اگر هیچ آیتمی انتخاب نشده بود، متوقف شود
                if (materialListBoxText.SelectedItem == null)
                {
                    MessageBox.Show("Please select an item in the list.");
                    return;
                }

                // پیدا کردن ایندکس آیتم انتخاب شده
                int selectedIndex = materialListBoxText.SelectedIndex;

                // اضافه کردن متن وارد شده به لیست در ایندکس مشخص شده
                materialListBoxText.Items.Insert(selectedIndex, new MaterialListBoxItem(materialTextBoxText.Text));

                // خالی کردن محتوای materialTextBoxText
                materialTextBoxText.Text = "";
            }
        }

        private void materialButtonReplaceText_Click(object sender, EventArgs e)
        {
            // بررسی اینکه مقدار موجود در materialTextBoxText خالی نیست
            if (!string.IsNullOrEmpty(materialTextBoxText.Text))
            {
                // بررسی اینکه آیا متن موجود در materialListBoxText است
                if (materialListBoxText.Items.Cast<MaterialListBoxItem>().Any(item => item.Text == materialTextBoxText.Text))
                {
                    MessageBox.Show("The text already exists in the list.");
                    return;
                }

                // بررسی اینکه آیا آیتمی در لیست انتخاب شده است
                if (materialListBoxText.SelectedItem != null)
                {
                    // پیدا کردن ایندکس آیتم انتخاب شده
                    int selectedIndex = materialListBoxText.SelectedIndex;

                    // حذف آیتم انتخاب شده از لیست
                    materialListBoxText.Items.RemoveAt(selectedIndex);

                    // اضافه کردن متن وارد شده در جایگاه آیتم حذف شده
                    materialListBoxText.Items.Insert(selectedIndex, new MaterialListBoxItem(materialTextBoxText.Text));

                    // خالی کردن محتوای materialTextBoxText
                    materialTextBoxText.Text = "";
                }
                else
                {
                    MessageBox.Show("Please select an item in the list.");
                }
            }
        }

        private void materialButtonSortText_Click(object sender, EventArgs e)
        {
            // گرفتن آیتم‌ها از listBox و تبدیل به آرایه
            MaterialListBoxItem[] itemsArray = new MaterialListBoxItem[materialListBoxText.Items.Count];
            materialListBoxText.Items.CopyTo(itemsArray, 0);

            // مرتب‌سازی آرایه بر اساس طول متن
            Array.Sort(itemsArray, (x, y) => x.Text.Length.CompareTo(y.Text.Length));

            // پاک کردن محتوای listBox
            materialListBoxTempText.Clear();

            // اضافه کردن موارد مرتب شده به listBox
            foreach (MaterialListBoxItem item in itemsArray)
            {
                materialListBoxTempText.Items.Add(item);
            }
        }

        private void materialButtonDeleteText_Click(object sender, EventArgs e)
        {
            // بررسی آیا آیتمی در لیست انتخاب شده است
            if (materialListBoxText.SelectedItem != null)
            {
                // حذف آیتم انتخاب شده از لیست
                materialListBoxText.Items.RemoveAt(materialListBoxText.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item in the list.");
            }
        }

        private void materialButtonCopyAllText_Click(object sender, EventArgs e)
        {
            // پاک کردن محتوای materialListBoxTempText
            materialListBoxTempText.Items.Clear();

            // اضافه کردن تمامی آیتم‌ها از materialListBoxText به materialListBoxTempText
            foreach (object item in materialListBoxText.Items)
            {
                materialListBoxTempText.Items.Add((MaterialListBoxItem)item);
            }
        }

        private void materialButtonClearAllText_Click(object sender, EventArgs e)
        {
            // پاک کردن محتوای materialListBoxText
            materialListBoxText.Items.Clear();
            // پاک کردن محتوای materialListBoxTempText
            materialListBoxTempText.Items.Clear();
        }

        private void materialTextBoxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // بررسی می‌کنیم که کاراکتر وارد شده یک حرف یا فاصله یا کاراکترهای مربوط به متن باشد
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // اگر کاراکتر وارد شده یک کاراکتر غیر مجاز بود، آن را قبول نمی‌کنیم
                e.Handled = true;
            }
        }
    }
}
