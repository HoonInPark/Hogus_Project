using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _AIA_TeamProject
{
    internal class Program
    {
        static public int money = 10000;
        class Branch
        {
            bool isMarket = true;

            /////////////
            int com = 0;
            int user = 0;
            bool isCh = true;

            string[] choice = { "가위", "바위", "보" };
            Random r = new Random();
            /////////////

            bool isGame = true;
            const int delay = 100;
            const string track = "-------------------------------------------------------------------------";
            int track_str = track.Length;

            int speed_Avante = 0;
            int speed_Benz = 0;
            int speed_Ford = 0;
            int speed_Tico = 0;
            int speed_Rockstar = 0;

            // 1. 게임 시작화면
            public void DrawTitle()
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                  ####### ######     #     #####  #    # ");
                Console.WriteLine("                                     #    #     #   # #   #     # #   #  ");
                Console.WriteLine("                                     #    #     #  #   #  #       #  #   ");
                Console.WriteLine("                                     #    ######  #     # #       ###    ");
                Console.WriteLine("                                     #    #   #   ####### #       #  #   ");
                Console.WriteLine("                                     #    #    #  #     # #     # #   #  ");
                Console.WriteLine("                                     #    #     # #     #  #####  #    # ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                              #         #####  #######    #    ######  #######");
                Console.WriteLine("                             ##        #     #    #      # #   #     #    #   ");
                Console.WriteLine("                           #  #        #          #     #   #  #     #    #   ");
                Console.WriteLine("                              #         #####     #    #     # ######     #   ");
                Console.WriteLine("                              #              #    #    ####### #   #      #   ");
                Console.WriteLine("                              #        #     #    #    #     # #    #     #   ");
                Console.WriteLine("                              #  #      #####     #    #     # #     #    #   ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                             #####           ####### #     # ### #######");
                Console.WriteLine("                            #     #          #        #   #   #     #   ");
                Console.WriteLine("                                  #          #         # #    #     #   ");
                Console.WriteLine("                             #####           #####      #     #     #   ");
                Console.WriteLine("                            #                #         # #    #     #   ");
                Console.WriteLine("                            #                #        #   #   #     #   ");
                Console.WriteLine("                            ####### #        ####### #     # ###    #   ");
                Console.ResetColor();

                int num = 0;

                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Clear();
                    DrawTitle();
                }

                switch (num)
                {
                    case 1:
                        Console.Clear();
                        Lobby();
                        break;

                    case 2:
                        EndPrint();
                        break;                    

                    default:
                        try
                        {
                            Console.Clear();
                            DrawTitle();
                        }
                        catch (Exception ex)
                        {
                            Console.Clear();
                            DrawTitle();
                        }
                        break;
                }                
            }


            // 2. 로비메뉴
            public void LobbyPrint()
            {
                Console.WriteLine();
                Console.WriteLine("TRACK 로비에 오신것을 환영합니다.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. 차권구매 후 경기장으로 이동");
                Console.WriteLine();
                Console.WriteLine("2. 내 소지금 확인하기");
                Console.WriteLine();
                Console.WriteLine("3. 매점 가기");
                Console.WriteLine();
                Console.WriteLine("4. 매점에서 알바하기");
                Console.WriteLine();
                Console.WriteLine("5. 인생 한방 가위바위보 보너스 게임!");
                Console.WriteLine();
                Console.WriteLine("6. 트랙 나가기");
            }


            // 2-1. 로비선택
            public void Lobby()
            {
                Console.Clear();
                LobbyPrint();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("원하시는 메뉴를 선택해 주세요. ==>");
                int num = 0;
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Lobby();
                }

                switch (num)
                {
                    case 1:
                        DrawGame();
                        break;

                    case 2:
                        Mymoney();
                        break;

                    case 3:
                        Market();
                        break;

                    case 4:
                        Work();
                        break;

                    case 5:
                        Three();
                        break;

                    case 6:
                        EndPrint();
                        break;

                    default:
                        try
                        {
                            Console.Clear();
                            Lobby();
                        }
                        catch(Exception ex)
                        {
                            Console.Clear();
                            Lobby();
                        }
                        break;
                }
            }

            // 2-1-1. 게임시작
            public void DrawGame()
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. Avante");
                Console.WriteLine("2. Benz");
                Console.WriteLine("3. Ford");
                Console.WriteLine("4. Tico");
                Console.WriteLine("5. Rockstar");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("차권은 1000원입니다.");
                Console.Write("구매하실 차권을 선택해 주세요. ==> ");
                
                int sel = 0;

                try
                {
                    sel = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Clear();
                    DrawGame();
                }



                switch (sel)
                {
                    case 1:
                        money -= 1000;
                        Console.WriteLine("아반떼를 선택하셨습니다. Enter를 누르시면 경기장으로 이동합니다.");
                        Console.ReadKey();
                        // 함수
                        break;

                    case 2:
                        money -= 1000;
                        Console.WriteLine("벤츠를 선택하셨습니다. Enter를 누르시면 경기장으로 이동합니다.");
                        Console.ReadKey();
                        // 함수
                        break;

                    case 3:
                        money -= 1000;
                        Console.WriteLine("포드를 선택하셨습니다. Enter를 누르시면 경기장으로 이동합니다.");
                        Console.ReadKey();
                        // 함수
                        break;

                    case 4:
                        money -= 1000;
                        Console.WriteLine("티코를 선택하셨습니다. Enter를 누르시면 경기장으로 이동합니다.");
                        Console.ReadKey();
                        // 함수
                        break;

                    case 5:
                        money -= 1000;
                        Console.WriteLine("록스타를 선택하셨습니다. Enter를 누르시면 경기장으로 이동합니다.");
                        Console.ReadKey();
                        // 함수
                        break;
                }

                while (isGame)
                {
                    Thread.Sleep(delay);

                    Console.Clear();

                    Random random = new Random();

                    double avante = random.NextDouble() * 3;
                    double benz = random.NextDouble() * 3;
                    double ford = random.NextDouble() * 3;
                    double tico = random.NextDouble() * 3;
                    double rockstar = random.NextDouble() * 3;

                    speed_Avante = (int)(speed_Avante + avante);
                    speed_Benz = (int)(speed_Benz + benz);
                    speed_Ford = (int)(speed_Ford + ford);
                    speed_Tico = (int)(speed_Tico + tico);
                    speed_Rockstar = (int)(speed_Rockstar + rockstar);

                    Console.WriteLine(track);

                    // 아반떼
                    for (int i = 0; i < speed_Avante; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("┌┘◎- -◎└┐");
                    Console.WriteLine();

                    // 벤츠
                    for (int i = 0; i < speed_Benz; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("<◎-┓-◎>");
                    Console.WriteLine();

                    // 포드
                    for (int i = 0; i < speed_Ford; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("<ⓥ-┴-ⓥ>");
                    Console.WriteLine();

                    // 티코
                    for (int i = 0; i < speed_Tico; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("<ⓒ-∞-ⓒ>");
                    Console.WriteLine();

                    // 록스타
                    for (int i = 0; i < speed_Rockstar; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("<ⓢ-㉤-ⓢ>");
                    Console.WriteLine();

                    Console.WriteLine(track);

                    if (speed_Avante >= track_str || speed_Benz >= track_str || speed_Ford >= track_str ||
                        speed_Tico >= track_str || speed_Rockstar >= track_str)
                    {
                        string winner = "";

                        if (speed_Avante >= track_str)
                        {
                            winner = "아반떼";
                        }
                        else if (speed_Benz >= track_str)
                        {
                            winner = "벤츠";
                        }
                        else if (speed_Ford >= track_str)
                        {
                            winner = "포드";
                        }
                        else if (speed_Tico >= track_str)
                        {
                            winner = "티코";
                        }
                        else if (speed_Rockstar >= track_str)
                        {
                            winner = "록스타";
                        }

                        if (sel == 1 && winner == "아반떼")
                        {
                            money = money + (1000 * 5);
                        }
                        else if (sel == 2 && winner == "벤츠")
                        {
                            money = money + (1000 * 5);
                        }
                        else if (sel == 3 && winner == "포드")
                        {
                            money = money + (1000 * 5);
                        }
                        else if (sel == 4 && winner == "티코")
                        {
                            money = money + (1000 * 5);
                        }
                        else if (sel == 5 && winner == "록스타")
                        {
                            money = money + (1000 * 5);
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"이번 경기는 {winner}가 승리 하였습니다!!!!");
                        Console.WriteLine($"현재 소지금은 {money}원 입니다.");
                        Console.WriteLine("로비로 돌아가시려면 아무키를 눌러주세요.");
                        isGame = false;

                        ConsoleKeyInfo cki;
                        cki = Console.ReadKey();
                        if (cki.Key == ConsoleKey.Enter)
                        {
                            speed_Avante = 0;
                            speed_Benz = 0;
                            speed_Ford = 0;
                            speed_Tico = 0;
                            speed_Rockstar = 0;

                            isGame = true;
                            Console.Clear();
                            Lobby();
                        }
                        else
                        {
                            speed_Avante = 0;
                            speed_Benz = 0;
                            speed_Ford = 0;
                            speed_Tico = 0;
                            speed_Rockstar = 0;

                            isGame = true;
                            Console.Clear();
                            Lobby();
                        }
                    }
                }

            }


            // 2-1-2. 내 소지금 확인하기
            public void Mymoney()
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"소지한 금액 ==> {money}원 입니다.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("나가시려면 아무키나 눌러주세요.");

                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Lobby();
                }
                else
                {
                    Console.Clear();
                    Lobby();
                }
            }

            // 3. 매점가기
            public void Market()
            {
                string[] menu = {"1. 라면 = 1,000원", "2. 치킨 = 7,000원", "3. 맥주 = 1,600원",
                                "4. 대마초 = 5,000,000원", "5. 콜라 = 700원", "6. 오징어 = 2500원",
                                "7. 계산하기"};

                int total = 0;

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("어서오세요 트랙마켓입니다.");

                Console.WriteLine();
                Console.WriteLine();

                while (isMarket)
                {
                    Console.Clear();

                    for (int i = 0; i < menu.Length; i++)
                    {
                        Console.WriteLine(menu[i]);
                    }

                    Console.WriteLine();
                    Console.WriteLine();

                    Console.Write("원하시는 메뉴를 선택해 주세요 ==> ");
                    int sel = 0;

                    try
                    {
                        sel = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        total = 0;
                        Console.WriteLine("죄송합니다! 물건이 없습니다. 다음에 다시 이용해 주세요!");
                        Console.ReadKey();
                        Lobby();
                    }

                    switch (sel)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine($"라면은 1,000원 입니다.");
                            Console.WriteLine();
                            total += 1000;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine($"치킨은 7,000원입니다.");
                            Console.WriteLine();
                            total += 7000;
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine($"맥주는 1,600원입니다.");
                            Console.WriteLine();
                            total += 1600;
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine($"대마초는 5,000,000원입니다.");
                            Console.WriteLine();
                            total += 5000000;
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine($"콜라는 700원입니다.");
                            Console.WriteLine();
                            total += 700;
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine($"오징어는 2500원입니다.");
                            Console.WriteLine();
                            total += 2500;
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine($"총 결제 금액은 {total}원 입니다.");
                            Console.WriteLine();
                            Console.WriteLine();
                            if (money >= total)
                            {
                                money -= total;
                                Console.WriteLine("감사합니다. 안녕히 가세요.");
                                Console.WriteLine();
                                Console.WriteLine($"남은 잔액은 {money}입니다.");
                            }
                            else if (money < total)
                            {
                                Console.WriteLine("돈이 모자릅니다. 일하면서 사세요.");
                                total = 0;
                                Console.ReadKey();
                                Lobby();
                            }
                            isMarket = false;
                            break;
                        default:
                            try
                            {
                                Console.Clear();
                                total = 0;
                                Console.WriteLine("죄송합니다! 물건이 없습니다. 다음에 다시 이용해 주세요!");
                                Console.ReadKey();
                                Lobby();
                            }
                            catch(Exception e)
                            {
                                Console.Clear();
                                total = 0;
                                Console.WriteLine("죄송합니다! 물건이 없습니다. 다음에 다시 이용해 주세요!");
                                Console.ReadKey();
                                Lobby();
                            }
                            break;
                    }
                }
                Console.WriteLine("나가시려면 아무키나 눌러주세요.");
                Console.WriteLine();
                Console.WriteLine();

                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    isMarket = true;
                    Lobby();
                }
                else
                {
                    Console.Clear();
                    isMarket = true;
                    Lobby();
                }
            }

            // 4. 알바하기
            public void Work()
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("일을하자....");

                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(i + " ");
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("1000원을 벌었다!!!  ~~ ■_(^O^)/");
                Console.WriteLine();
                Console.WriteLine();
                money += 1000;
                Console.WriteLine($"소지한 금액 ==> {money}원 입니다.");
                Console.WriteLine("나가시려면 아무키나 눌러주세요.");
                Console.WriteLine();
                Console.WriteLine();

                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Lobby();
                }
                else
                {
                    Console.Clear();
                    Lobby();
                }
            }

            // 5. 트랙 나가기
            public void EndPrint()
            {
                Console.WriteLine();
                Random Rand = new Random();
                ConsoleColor[] Color = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow };

                Console.Clear();
                for (int i = 0; i < 3; ++i)
                {
                    Console.ForegroundColor = Color[i/*Rand.Next(3)*/]; //0~5까지의 랜덤한 색상으로 폰트색변경

                    Console.WriteLine();
                    Console.WriteLine("                 #####     #    #     # #######    ####### #     # ####### ###### ");
                    Console.WriteLine("                #     #   # #   ##   ## #          #     # #     # #       #     # ");
                    Console.WriteLine("                #        #   #  # # # # #          #     # #     # #       #     # ");
                    Console.WriteLine("                #  #### #     # #  #  # #####      #     # #     # #####   ######  ");
                    Console.WriteLine("                #     # ####### #     # #          #     #  #   #  #       #   #   ");
                    Console.WriteLine("                #     # #     # #     # #          #     #   # #   #       #    #  ");
                    Console.WriteLine("                 #####  #     # #     # #######    #######    #    ####### #     # ");
                    Console.WriteLine();

                    Thread.Sleep(500); //0.5초대기
                }

                Thread.Sleep(1000); //0.5초대기
                Environment.Exit(0);
            }

            public void Three()
            {
                Console.Clear();

                while (isCh)
                {
                    money -= 1000;
                    com = r.Next(1, 4);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("가위, 바위, 보 게임을 시작합니다!");
                    Console.WriteLine("승리하시면 3배의 금액이 지급됩니다!");
                    Console.WriteLine("패배 하시면 돈을 잃게 되시니 주의하세요!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("1 : 가위, 2 : 바위, 3 : 보");
                    Console.Write("번호를 선택해 주세요 ==> ");
                    //user = int.Parse(Console.ReadLine());

                    int user = 0;

                    try
                    {
                        user = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        user = 0;
                        Console.WriteLine("잘못입력 하셨습니다! 다음에 다시 도전해 주세요!");
                        Console.ReadKey();
                        Lobby();
                    }

                    Console.Clear();

                    if (user == com)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("######  ######     #    #     #");
                        Console.WriteLine("#     # #     #   # #   #  #  #");
                        Console.WriteLine("#     # #     #  #   #  #  #  #");
                        Console.WriteLine("#     # ######  #     # #  #  #");
                        Console.WriteLine("#     # #   #   ####### #  #  #");
                        Console.WriteLine("#     # #    #  #     # #  #  #");
                        Console.WriteLine("######  #     # #     #  ## ## ");

                        isCh = false;
                    }
                    else if (user == 1 && com == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("#     #  #  #     #");
                        Console.WriteLine("#  #  #  #  ##    #");
                        Console.WriteLine("#  #  #  #  # #   #");
                        Console.WriteLine("#  #  #  #  #  #  #");
                        Console.WriteLine("#  #  #  #  #   # #");
                        Console.WriteLine("#  #  #  #  #    ##");
                        Console.WriteLine(" ## ##   #  #     #");

                        money += 7000;
                        isCh = false;
                    }
                    else if (user == 1 && com == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("#        #####   #####  #######");
                        Console.WriteLine("#       #     # #     # #");
                        Console.WriteLine("#       #     # #       #");
                        Console.WriteLine("#       #     #  #####  #####");
                        Console.WriteLine("#       #     #       # #");
                        Console.WriteLine("#       #     # #     # #");
                        Console.WriteLine("####### #######  #####  #######");

                        isCh = false;
                    }
                    else if (user == 2 && com == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("#     #  #  #     #");
                        Console.WriteLine("#  #  #  #  ##    #");
                        Console.WriteLine("#  #  #  #  # #   #");
                        Console.WriteLine("#  #  #  #  #  #  #");
                        Console.WriteLine("#  #  #  #  #   # #");
                        Console.WriteLine("#  #  #  #  #    ##");
                        Console.WriteLine(" ## ##   #  #     #");

                        money += 7000;
                        isCh = false;
                    }
                    else if (user == 2 && com == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("#        #####   #####  #######");
                        Console.WriteLine("#       #     # #     # #");
                        Console.WriteLine("#       #     # #       #");
                        Console.WriteLine("#       #     #  #####  #####");
                        Console.WriteLine("#       #     #       # #");
                        Console.WriteLine("#       #     # #     # #");
                        Console.WriteLine("####### #######  #####  #######");

                        isCh = false;
                    }
                    else if (user == 3 && com == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("#        #####   #####  #######");
                        Console.WriteLine("#       #     # #     # #");
                        Console.WriteLine("#       #     # #       #");
                        Console.WriteLine("#       #     #  #####  #####");
                        Console.WriteLine("#       #     #       # #");
                        Console.WriteLine("#       #     # #     # #");
                        Console.WriteLine("####### #######  #####  #######");

                        isCh = false;
                    }
                    else if (user == 3 && com == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("#     #  #  #     #");
                        Console.WriteLine("#  #  #  #  ##    #");
                        Console.WriteLine("#  #  #  #  # #   #");
                        Console.WriteLine("#  #  #  #  #  #  #");
                        Console.WriteLine("#  #  #  #  #   # #");
                        Console.WriteLine("#  #  #  #  #    ##");
                        Console.WriteLine(" ## ##   #  #     #");

                        money += 7000;
                        isCh = false;
                    }
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"현재 소지금은 {money}원 입니다.");
                Console.WriteLine("로비로 돌아가시려면 아무키를 눌러주세요.");

                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Enter)
                {
                    speed_Avante = 0;
                    speed_Benz = 0;
                    speed_Ford = 0;
                    speed_Tico = 0;
                    speed_Rockstar = 0;

                    isCh = true;
                    Console.Clear();
                    Lobby();
                }
                else
                {
                    speed_Avante = 0;
                    speed_Benz = 0;
                    speed_Ford = 0;
                    speed_Tico = 0;
                    speed_Rockstar = 0;

                    isCh = true;
                    Console.Clear();
                    Lobby();
                }
            }
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 30);
            Branch branch = new Branch();


            while (true)
            {
                branch.DrawTitle();
            }
        }
    }
}
