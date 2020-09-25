using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0925
{
	class DateTime1
	{
		static void Main(string[] args)
		{
			//DateTime은 구조체로서 값타입
			Console.WriteLine(DateTime.Now); //년월일시분초 까지 나오고
			Console.WriteLine(DateTime.Today);//년월일 만나옴
			Console.WriteLine(DateTime.Now.ToShortDateString()); //짧은 날짜만 나오는 함수
			Console.WriteLine(DateTime.Now.ToLongDateString()); //긴 날짜만 나오는 함수

			#region 내가 태어난 일수 구하기
			DateTime to = DateTime.Now;
			DateTime from = new DateTime(1995, 7, 14); // 생성자 생성
			TimeSpan interval = to - from;
			//Console.WriteLine((to - from).Days); //TimeSpan에 Days속성을 가져와 일만 뽑아냄
			Console.WriteLine(interval.Days);
			#endregion

			#region DateTime 연산, string 형변환
			//string str = DateTime.Now.AddDays(3).ToShortDateString(); //일을 더하는 메서드에 일까지만 출력해주는 매서드
			//string str = DateTime.Now.AddDays(3).ToString(); //Datetime은 형변환을 Tostring을 붙여서 한다
			string str = DateTime.Now.AddDays(3).ToString("yyyy.MM.dd"); //이렇게도 가능
			Console.WriteLine(str);
			#endregion

			#region 내가 짠 전역일 구하기
			DateTime freedom = new DateTime(2017, 10, 25);
			DateTime now = DateTime.Now;
			Console.WriteLine((now - freedom).Days);
			#endregion

			#region 전역한지 1000일 된날 구하기
			Console.WriteLine((new DateTime(2017,10,25)).AddDays(1000).ToShortDateString());
			#endregion


			#region 내일 정처기 시험 전까지 얼마나 남았는지 계산하기

			DateTime dDay = new DateTime(2020, 9, 26, 13, 0, 0);
			double rHour = (dDay - DateTime.Now).TotalHours; //시간으로 나타내 주는 TimeSpan속성
			Console.WriteLine(rHour);

			#endregion
		}
	}
}
