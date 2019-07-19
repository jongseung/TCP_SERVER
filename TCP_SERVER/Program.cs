using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*
TCP통신 기반의 1Room 멀티채팅 서버 프로그램
기능
메인스레드
서버 설정, 클라이언트 접속 대기, 접속한 클라이언트를 매개변수로 서브스레드 생성
서브스레드1
클라이언트가 송신한 채팅내용을 다른클라이언트에게 송신
서브스레드2...n
클라이언트가 송신 데이터를 수신 및 채팅내용을 저장변수에 전달
*/
namespace TCP_SERVER
{
    //접속한 클라이언트를 관리하는 클래스
    class User
    {
        //접속한 클라이언트의 소켓, 스트림
        //BinaryFormatter 객체
        //10값 저장변수
        //서브스레드 - 클라이언트가 송신한 데이터를 수신받아 메세지저장변수에 누적
        // 해당 클라이언트에게 데이터를 송신하는 메소드
        //클라이언트 연결종료 메소드

    }
    //서버를 관리하는 클래스
    class Manager
    {
        //서버소켓
        //List<User>
        //메세지 저장용 변수 List<string>
        //서브스레드 관리용 변수 List<Task>
        //BinaryFormatter

        //메인 스레드용
        //서버생성
        //클라이언트 접속 허용 및 접속 대기
        //서버닫기

        //서브 스레드 1번용
            //메세지 저장 변수에서 문자열 추출 및 해당 문자열을 연결된 클라이언트에게 송신
    }
    class program
    {

        static void Main(string[] args)
        {

        }

    }
}