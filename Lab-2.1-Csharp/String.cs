
namespace StringLibrary
{
    public class StringBase
    {
        protected string value;

        // Конструктор за замовчуванням
        public StringBase()
        {
            value = string.Empty;
        }

        // Конструктор з параметром
        public StringBase(string str)
        {
            value = str ?? string.Empty;
        }

        // Копіюючий конструктор
        public StringBase(StringBase other)
        {
            value = other.value ?? string.Empty;
        }

        // Властивість для читання значення рядка
        public string Value
        {
            get { return value; }
        }

        // Метод обчислення довжини рядка
        public virtual int CalculateLength()
        {
            return value.Length;
        }
    }
    public class NumericString : StringBase
    {
        // Конструктор за замовчуванням 
        public NumericString() : base()
        {
        }

        // Конструктор з параметром 
        public NumericString(string str) : base(str)
        {
        }

        // Копіюючий конструктор 
        public NumericString(NumericString other) : base(other)
        {
        }


        // Метод для отримання довжини рядка 
        public override int CalculateLength()
        {
            return base.CalculateLength();
        }

        // Додаткові методи для отримання даних об'єкта
        public string GetStringValue()
        {
            return Value;
        }

        // Метод видалення заданого символу з рядка
        public void RemoveCharacter(char charToRemove)
        {
            value = value.Replace(charToRemove.ToString(), "");
        }
    }
}