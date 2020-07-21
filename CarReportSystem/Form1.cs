using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }


        //データの追加
        private void btDataAdd_Click(object sender, EventArgs e) {

            displayErrorMessage("まだ追加できないよ。");

        }


        //テキストのクリア
        private void textBoxesClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = "";
            rbToyota.Checked = true;
            cbCarName.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;
        }


        //コンボボックスにアイテムを追加
        private void cbItemsAdd(string recoderItem, string nameItem) {
            //記録者のアイテム登録
            if(!cbAuthor.Items.Contains(recoderItem)) {
                cbAuthor.Items.Add(recoderItem);
            }
            //車名のアイテム登録
            if(!cbCarName.Items.Contains(nameItem)) {
                cbCarName.Items.Add(nameItem);
            }
        }


        //ラジオボタンの判別
        private string getRadioButton() {

            if(rbToyota.Checked) {
                return rbToyota.Text;
            } else if(rbNissan.Checked) {
                return rbNissan.Text;
            } else if(rbHonda.Checked) {
                return rbHonda.Text;
            } else if(rbSubaru.Checked) {
                return rbSubaru.Text;
            } else if(rbGaisya.Checked) {
                return rbGaisya.Text;
            } else if(rbSonota.Checked) {
                return rbSonota.Text;
            } else {
                return "null";
            }
        }


        //画像を開く
        private void btImageOpen_Click(object sender, EventArgs e) {

            try {
                if(ofdOpenData.ShowDialog() == DialogResult.OK) {
                    //選択した画像をピクチャーボックスに表示
                    pbCarImage.Image = Image.FromFile(ofdOpenData.FileName);
                    //ピクチャーボックスのサイズに画像を調整
                    pbCarImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            } catch(OutOfMemoryException) {
                displayErrorMessage("画像ファイルを選択してください。");
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


        //データの削除
        private void btDataClear_Click(object sender, EventArgs e) {

            displayErrorMessage("削除できないよ。");

            dgvCarReportData.ClearSelection();  //選択解除
            //ボタンの無効化を判断
            activationButton();

        }


        //データの修正
        private void btDataFix_Click(object sender, EventArgs e) {

            //nullを許容していないものに値が入っていない場合
            if(cbAuthor.Text == "" || cbCarName.Text == "") {
                displayErrorMessage("記録者と車名を入力してください。");
                return;
            }

            dgvCarReportData.CurrentRow.Cells[1].Value = dtpDate.Value.Date;
            dgvCarReportData.CurrentRow.Cells[2].Value = cbAuthor.Text;
            dgvCarReportData.CurrentRow.Cells[3].Value = getRadioButton();
            dgvCarReportData.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvCarReportData.CurrentRow.Cells[5].Value = tbReport.Text;

            if(pbCarImage.Image == null) {
                dgvCarReportData.CurrentRow.Cells[6].Value = null;

            } else {
                var imageByte = ImageToByteArray(pbCarImage.Image);
                dgvCarReportData.CurrentRow.Cells[6].Value = imageByte;
            }


            //反映
            DatabaseSave();

        }


        //データグリッドビューを選択
        private void dgvCarReportData_Click(object sender, EventArgs e) {

            //データがなかった場合
            if(dgvCarReportData.CurrentRow == null) {
                return;
            }

            //ラジオボタン
            switch(dgvCarReportData.CurrentRow.Cells[3].Value) {
                case "DEFAULT":
                    break;
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外車":
                    rbGaisya.Checked = true;
                    break;
                case "その他":
                    rbSonota.Checked = true;
                    break;
                default:
                    rbSonota.Checked = true;
                    break;
            }


            //テキストボックス等に表示
            if(dgvCarReportData.CurrentRow.Cells[1].Value.ToString() == "") {
                dtpDate.Value = DateTime.Today;
            } else {
                dtpDate.Value = (DateTime)dgvCarReportData.CurrentRow.Cells[1].Value;
            }
            cbAuthor.Text = dgvCarReportData.CurrentRow.Cells[2].Value.ToString();
            cbCarName.Text = dgvCarReportData.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = dgvCarReportData.CurrentRow.Cells[5].Value.ToString();

            if(dgvCarReportData.CurrentRow.Cells[6].Value.ToString() == "") {
                pbCarImage.Image = null;
            } else {
                var byteArray = (byte[])dgvCarReportData.CurrentRow.Cells[6].Value;
                pbCarImage.Image = ByteArrayToImage(byteArray);
            }

            //ピクチャーボックスのサイズに画像を調整
            pbCarImage.SizeMode = PictureBoxSizeMode.StretchImage;


        }


        //エラーメッセージボックスの表示
        private void displayErrorMessage(string textMessage) {
            MessageBox.Show(textMessage,
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }


        //ゲットデータ
        private void getData(CarReport selectedCR) {

            dtpDate.Value = selectedCR.CreatedDate;
            cbAuthor.Text = selectedCR.Author;
            cbCarName.Text = selectedCR.Name;
            tbReport.Text = selectedCR.Report;
            pbCarImage.Image = selectedCR.Picture;

            //ラジオボタン
            switch(selectedCR.Maker) {
                case CarReport.CarMaker.DEFAULT:
                    break;
                case CarReport.CarMaker.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.CarMaker.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.CarMaker.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.CarMaker.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.CarMaker.外車:
                    rbGaisya.Checked = true;
                    break;
                case CarReport.CarMaker.その他:
                    rbSonota.Checked = true;
                    break;
                default:
                    break;
            }
        }


        //セットデータ
        //private void setData(CarReport selectedCR) {

        //    selectedCR.CreatedDate = dtpDate.Value;
        //    selectedCR.Author = cbAuthor.Text;
        //    selectedCR.Maker = getRadioButton();
        //    selectedCR.Name = cbCarName.Text;
        //    selectedCR.Report = tbReport.Text;
        //    selectedCR.Picture = pbCarImage.Image;
        //}


        //セーブファイルダイアログを表示
        private void btDataSave_Click(object sender, EventArgs e) {

            displayErrorMessage("保存できないよ。");

            //if(sfdSaveData.ShowDialog() == DialogResult.OK) {
            //    BinaryFormatter formatter = new BinaryFormatter();

            //    //ファイルストリームを生成
            //    using(FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create)) {
            //        try {
            //            //シリアル化して保存
            //            formatter.Serialize(fs, _CarReports);
            //        } catch(SerializationException se) {
            //            Console.WriteLine("Failed to serialize. Reason: " + se.Message);
            //            displayErrorMessage("保存時にエラーが発生しました。");
            //        }
            //    }
            //}
        }


        //オープンファイルダイアログを表示
        private void btDataOpen_Click(object sender, EventArgs e) {

            displayErrorMessage("ファイル開けないよ。");

            //if(ofdOpenData.ShowDialog() == DialogResult.OK) {
            //    using(FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open)) {
            //        try {
            //            BinaryFormatter formatter = new BinaryFormatter();
            //            //逆シリアル化して読み込む
            //            _CarReports = (BindingList<CarReport>)formatter.Deserialize(fs);
            //            //データグリッドビューに再設定
            //            dgvCarReportData.DataSource = _CarReports;
            //            //選択されている箇所を各コントロールへ表示
            //            dgvCarReportData_Click(sender, e);
            //        } catch(SerializationException se) {
            //            Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
            //            displayErrorMessage("読み込み時にエラーが発生しました。");
            //        }
            //    }
            //}
        }


        //ボタンを有効化
        private void activationButton() {
            if(dgvCarReportData.Rows.Count == 0) {
                btDataClear.Enabled = false;
                btDataFix.Enabled = false;
            } else {
                btDataClear.Enabled = true;
                btDataFix.Enabled = true;
            }
        }


        //接続メニューをクリック
        private void 接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.carReportTableAdapter.Fill(this.infosys202006DataSet.CarReport);


            //コンボボックスにアイテムを追加
            for(int i = 0; i < dgvCarReportData.RowCount; i++) {
                cbItemsAdd(dgvCarReportData.Rows[i].Cells[2].Value.ToString(), dgvCarReportData.Rows[i].Cells[4].Value.ToString());
            }

            //ボタンの有効化
            activationButton();
            //選択解除
            dgvCarReportData.ClearSelection();

        }


        //フォームロード時
        private void Form1_Load(object sender, EventArgs e) {
            //IDを非表示にする
            dgvCarReportData.Columns[0].Visible = false;
        }


        //バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] byteData) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }


        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }


        //データベース反映
        private void DatabaseSave() {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202006DataSet);
        }
    }
}
