using System;
using DoitPinYin.Tools;
using Microsoft.International.Converters.TraditionalChineseToSimplifiedConverter;


namespace DoitPinYin {
class Program {
    static void Main(string[] args) {

        string testChinese = "快樂";
        Console.WriteLine("全拼：{0}", MsPinYinHelper.PinYin(testChinese));
        Console.WriteLine("简拼：{0}", MsPinYinHelper.FirstPinYin(testChinese));
        Console.WriteLine("该字符是否是多音字：{0}", MsPinYinHelper.IsPolyphone(testChinese));
        Console.WriteLine("该字符拼音个数：{0}", MsPinYinHelper.PinYinCount(testChinese));//字符拼音个数
        Console.WriteLine("该字符笔画：{0}", MsPinYinHelper.StrokeNumber(testChinese));//获得字符笔画数
        Console.WriteLine("转为繁体后是：{0}", MsPinYinHelper.SimplifiedToTraditional(testChinese));
        Console.WriteLine("快樂转为简体后是：{0}", MsPinYinHelper.TraditionalToSimplified("快樂"));
        Console.ReadLine();
    }
}
}
