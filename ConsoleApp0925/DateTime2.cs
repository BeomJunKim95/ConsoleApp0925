using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp0925
{
	class DateTime2
	{
		static void Main()
		{
			#region 계속 시간이 지날때마다 찍고싶을때(Timer)
			////타이머 클래스 사용
			System.Timers.Timer timer1 = new System.Timers.Timer(); // 닷넷에 타이머는 윈폼이랑 역할이 좀다름
			timer1.Interval = 1000; //밀리세컨드
			timer1.Elapsed += Timer1_Elapsed; //이벤트 등록 => 델리게이트까지 다쓰기 너무 길어서 이렇게 생략
			timer1.Start(); // 타이머 시작 메서드

			Console.ReadLine(); //메인함수가 끝나지 못하게 잡아두는 것

			Console.WriteLine(DateTime.Now); //이벤트 메서드로 보내기
											 //멀티스레드 뭐시기라 안쓰면 안된다는데 지금은 모름 나중에 배울예정

			#endregion

			#region  달 말일 구하기
			//이번달 1 ~ 말일
			DateTime from = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
			DateTime to = from.AddMonths(1).AddDays(-1);
			//반드시 날짜계산을 하려면 string이 아니라 DateTime을 써야한다
			Console.WriteLine($"이번달은 {from.ToShortDateString()} ~ {to.ToShortDateString()} 입니다.");

			#endregion

			#region 오늘이 포함된 이번주 구하기
			//이번주 일~토 
			from = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek); // 열거형은 int니까 int로 형변환을 하면 인덱스로 반환해줌
			to = from.AddDays(6);
			Console.WriteLine($"이번주는 {from.ToLongDateString()} ~ {to.ToLongDateString()} 입니다.");
			
			//이번주 월~일
			from = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + 1);
			to = from.AddDays(6);
			Console.WriteLine($"이번주는 {from.ToLongDateString()} ~ {to.ToLongDateString()} 입니다.");

			#endregion
		}

		private static void Timer1_Elapsed(object sender, ElapsedEventArgs e)
		{
			Console.WriteLine(DateTime.Now);
		}
	}
}
