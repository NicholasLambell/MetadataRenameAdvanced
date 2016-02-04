using System.Windows.Forms;

namespace MetadataRenameAdvanced {
    class ErrorHandler {
        public static void LogError(string error, bool showDialog) {
            //Log to file code here

            if (showDialog) {
                MessageBox.Show(error, "Error!");
            }
        }
    }
}
