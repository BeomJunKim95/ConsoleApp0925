using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0925
{
	class String1
	{
		static void Main()
		{
			string str1 = "가나다라마바사";
			string str2 = "가나다라마바사";


			// Contains : 지정한 문자열이 문자열 안에 있는지 True False로 반환해주는 메서드
			Console.WriteLine(str1.Contains("라마"));
			Console.WriteLine(str2.Contains('가')); // 작은 따옴표(' ')는 문자하나
												   //Contains 메서드는 문자 문자열 모두 가능

			//while (true)
			//{
			//	Console.Write("당신의 이메일을 입력해주세요 : ");
			//	string str_Email = Console.ReadLine();
			//	if (!str_Email.Contains('@'))
			//	{
			//		Console.WriteLine("유효한 이메일이 아닙니다. 다시 입력해주세요");
			//	}
			//	if (str_Email.IndexOf("@") < 1)
			//	{
			//		Console.WriteLine("유효한 이메일이 아닙니다. 다시 입력해주세요");
			//	}
			//}

			#region 주민번호입력후 생년월일 성별 표기 (내코드)

			//while (true)
			//{
			//	Console.Write("당신의 주민등록번호 앞에서부터 7자리를 -빼고 입력해주세요 (ex : 950714-1 => 9507141 )\n => ");
			//	try
			//	{

			//		string strNum = Console.ReadLine();
			//		string strYear = strNum.Substring(0, 2);
			//		string strMonth = strNum.Substring(2, 2);
			//		string strDay = strNum.Substring(4, 2);
			//		string strSex = strNum.Substring(6);

			//		if (strSex == "1")
			//		{
			//			Console.WriteLine($"생년월일 : 19{strYear}년 {strMonth}월 {strDay}일");
			//			Console.WriteLine("성별 : 남자");
			//		}
			//		else if (strSex == "2")
			//		{
			//			Console.WriteLine($"생년월일 : 19{strYear}년 {strMonth}월 {strDay}일");
			//			Console.WriteLine("성별 : 여자");
			//		}
			//		else
			//			throw new Exception("유효하지 않는 주민번호 입니다.\n");
			//	}
			//	catch (Exception err)
			//	{
			//		Console.WriteLine(err.Message);
			//	}
			//}
			#endregion

			#region 주민번호입력후 생년월일 성별 표기(선생님코드)

			//Console.Write("당신의 주민등록번호 앞에서부터 7자리를 -빼고 입력해주세요 (ex : 950714-1 => 9507141 )\n => ");
			//string strJumin = Console.ReadLine();
			//if (strJumin.Length != 7)
			//{
			//	Console.WriteLine("주민등록번로 앞 7자리를 입력해주세요");
			//}// 9707081
			//string year, month, day, sex, gubun;
			//if (strJumin.Substring(6) == "1" || strJumin.Substring(6) == "2" || strJumin.Substring(6) == "5" || strJumin.Substring(6) == "6")
			//	gubun = "19";
			//else if (strJumin.Substring(6) == "3" || strJumin.Substring(6) == "4")
			//	gubun = "20";
			//else
			//	gubun = "20";

			//year = string.Concat(gubun, strJumin.Substring(0, 2)); //Concat : 지정된 두 인스턴스를 연결하는 메서드
			//month = strJumin.Substring(2, 2).TrimStart('0'); // TrimStart : 앞자리의 0을 제거해줌 (07월을 7월로 표시하고 10,11,12,월은 그대로 표기)
			//day = strJumin.Substring(4, 2);
			//sex = (strJumin.Substring(6) == "1" || strJumin.Substring(6) == "3" || strJumin.Substring(6) == "5") ? "남" : "여"; // 조건문 ? str1 : str2 => 앞에 조건문이 참이면 str1 실행 거짓이면 str2실행

			//Console.WriteLine($"출생년월 : {year}년 {month}월 {day}일 \n성별 : {sex}");

			#endregion

			#region 경로에서 파일명과 파일 확장자만 걸러서 출력하기
			//C:/Users/GDC5/Pictures/image/20191024114946.jpg
			// 파일명만 출력되게 해보자 => 역슬래쉬를 구분자로 보고 

			string strFileName = @"C:\Users\GDC5\Pictures\image\20191024114946.jpg"; // 역슬래쉬는 특수기호라 두개씩쳐야 인식하는데 귀찮으니 @사용

			Console.WriteLine("파일명만 출력");
			string fileName = strFileName.Substring(strFileName.LastIndexOf('\\') + 1); // LastIndexOf는 처음찾은 뒤에서 \부터 인덱스를 알려주기때문에 \를 빼고 담기위해 인덱스 +1
			Console.WriteLine(fileName);

			Console.WriteLine("확장자만 출력");
			string ext = fileName.Substring(fileName.IndexOf('.') + 1);
			if(ext.ToUpper().Equals("EXE"))
				Console.WriteLine("첨부할 수 없는 파일 입니다.");
			Console.WriteLine(ext);

			#endregion

			#region 오늘의 주문번호 만들기
			//오늘의 15번째 주문번호
			//일단 년월일 붙여서 출력 해보기
			//1번째 방법
			string today = DateTime.Now.ToString("yyyyMMdd");
			Console.WriteLine(today);
			//2번째 방법
			//today = DateTime.Now.ToShortDateString().Replace("-", "");
			//Console.WriteLine(today);
			//하지만 간결하게 포맷을 정해서 하는 1번째 방법이 더 좋아보임

			int cnt = 15;
			string orderNum = today + cnt.ToString().PadLeft(5, '0'); // PadRight, PadLeft함수 : 지정한 길이만큼 왼쪽이나 오른쪽으로 밀어서 지정된 글자로 남은 길이를 채워줌
			Console.WriteLine(orderNum);
			#endregion
		}
	}
}
