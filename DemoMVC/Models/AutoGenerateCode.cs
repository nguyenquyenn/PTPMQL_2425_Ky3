namespace DemoMVC.Models
{
    public class AutoGenerateCode
    {
        public string GenerateCode(string id)
        {
            // 1. Tách phần chữ và số 
            string prefix = new string(id.TakeWhile(c => !char.IsDigit(c)).ToArray());
            string numberPart = new string(id.SkipWhile(c => !char.IsDigit(c)).ToArray());

            // 2. Chuyển phần số sang int rồi tăng lên 1
            int number = int.Parse(numberPart);
            number++;

            // 3. Ghép lại
            string newId = prefix + number.ToString("D" + numberPart.Length);
            return newId;
        }
    }
}
