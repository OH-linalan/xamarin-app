using System;

namespace console1{
    class programs{
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, world");
            object o = true;
                // object 형식은 모든 데이터 타입을 담고 처리할수 있음
                // C#에서 모든 객체들은 object 클래스로 부터 상속을 받음
            int[] arr = {1,2,3,4,5,6,7,8,9};
            foreach (int i in arr){
                Console.WriteLine("i: {0}",i);
            }
                //python의 in 과 비슷함
            string li = Console.ReadLine();//문자열 받음
            int num = int.Parse(li);//정수로 바꿈
        }
    }
}