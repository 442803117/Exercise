﻿using System;


namespace DoitPinYin {
class Program {
    static void Main(string[] args) {
        string testChinese = "张";
        Console.WriteLine("该汉字字符是:" + chinesechar.ChineseCharacter);
        Console.WriteLine("该字符是否是多音字：" + chinesechar.IsPolyphone);
        Console.WriteLine("该字符拼音个数：" + chinesechar.PinyinCount);//字符拼音个数
        Console.WriteLine("该字符笔画：" + chinesechar.StrokeNumber.ToString());//获得字符笔画数
        Console.WriteLine("快乐程序设计转为繁体后是：" + ChineseConverter.Convert("快乐程序设计", ChineseConversionDirection.SimplifiedToTraditional));
        Console.WriteLine("快樂程序設計转为繁体后是：" + ChineseConverter.Convert("快樂程序設計", ChineseConversionDirection.TraditionalToSimplified));
        Console.ReadLine();
    }
}
}
