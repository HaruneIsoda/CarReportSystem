using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //バインディングリスト
        BindingList<CarReport> _CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReportData.DataSource = _CarReports;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        //データの追加
        private void btDataAdd_Click(object sender, EventArgs e) {

            var carReport = new CarReport() {
                CreatedDate = dtpDate.Value.Date,
                Recoder = cbRecoder.Text,
                Maker = RadioButtonCheckNumber(),
                Name = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbCarImage.Image
            };

            //リストに追加
            _CarReports.Insert(0, carReport);
            //コンボボックスにアイテムを追加
            CbItemsAdd(cbRecoder.Text,cbCarName.Text);
            //入力後テキストクリア
            TextBoxesClear();

        }

        //テキストのクリア
        private void TextBoxesClear() {
            dtpDate.Value = DateTime.Today;
            cbRecoder.Text = "";
            rbToyota.Checked = true;
            cbCarName.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;
        }

        private void CbItemsAdd(string recoderItem, string nameItem) {
            //記録者のアイテム登録
            if(!cbRecoder.Items.Contains(recoderItem)) {
                cbRecoder.Items.Add(recoderItem);
            }
            //車名のアイテム登録
            if(!cbCarName.Items.Contains(nameItem)) {
                cbCarName.Items.Add(nameItem);
            }
        }

        //ラジオボタンの判別
        private CarReport.CarMaker RadioButtonCheckNumber() {

            if(rbToyota.Checked) {
                return CarReport.CarMaker.トヨタ;
            } else if(rbNissan.Checked) {
                return CarReport.CarMaker.日産;
            } else if(rbHonda.Checked) {
                return CarReport.CarMaker.ホンダ;
            } else if(rbSubaru.Checked) {
                return CarReport.CarMaker.スバル;
            } else if(rbGaisya.Checked) {
                return CarReport.CarMaker.外車;
            } else if(rbSonota.Checked) {
                return CarReport.CarMaker.その他;
            } else {
                return CarReport.CarMaker.DEFAULT;
            }
        }

        //画像を開く
        private void btImageOpen_Click(object sender, EventArgs e) {
            {
                if(ofdOpenPictureImage.ShowDialog() == DialogResult.OK) {
                    //選択した画像をピクチャーボックスに表示
                    pbCarImage.Image = Image.FromFile(ofdOpenPictureImage.FileName);
                    //ピクチャーボックスのサイズに画像を調整
                    pbCarImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        //画像を削除
        private void btImageClear_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }

        //終了
        private void btEnd_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
