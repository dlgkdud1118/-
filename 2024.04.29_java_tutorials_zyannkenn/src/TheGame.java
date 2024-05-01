import java.util.ArrayList;
import java.util.Date;

public class TheGame{

	private java.util.Scanner scanner = new java.util.Scanner(System.in);
	
	private ArrayList<String> gameResults = new ArrayList<>();
	private ArrayList<GameResult> gameResults2 = new ArrayList<>();
	
	public void doGame() {
		outer: while(true) {
			String selection = selectMenu();
			
			System.out.println();
			
			switch(selection) {
			case "1":
				int comNumber = makeComNumber();
					
					int userNumber = inputUserNumber();
					
					String result = makeDecision(userNumber, comNumber);
					
					showResult(comNumber, userNumber, result);
			
					gameResults.add(result); //결과 저장
					GameResult gr = new GameResult(0, new Date(), comNumber, userNumber, result);
					gameResults2.add(gr);
					break;
			case "2":
				for (String gameResult : gameResults) {
					System.out.println(gameResult);
				}
				for(GameResult gameResult : gameResults2) {
					System.out.println(gameResult);
				}
				break;
				
			case "9":
				System.out.println("**** 終了 ****");
				break outer;
			default:
				System.out.println("**** 対応していない命令です。***");
				break;
			}
			System.out.println();
		}
		scanner.close();
	}

	public String selectMenu() {
		System.out.println("-----------------------------------");
		System.out.println("1. じゃん拳ゲーム開始");
		System.out.println("2. ゲーム結果");
		System.out.println("9. 終了 ");
		System.out.println("-----------------------------------");
		System.out.print("ジョブを選択してください : ");
		String selection = scanner.next();
		
		return selection;
	}
	
	public int makeComNumber() {
		double n = Math.random()*3;
		int comNumber = (int)(n + 1);
		return comNumber;
	}

	public int inputUserNumber() {
		String sUserNumber;
		do {
				System.out.print("チョキ/グー/パー 入力 (チョキ=1, グー＝2, パー= 3 : ");
				sUserNumber = scanner.next();
		} while (!sUserNumber.equals("1") &&
						!sUserNumber.equals("2") &&
						!sUserNumber.equals("3"));
		int userNumber = Integer.parseInt(sUserNumber);
		return userNumber;
	}

	public String makeDecision(int userNumber, int comNumber) { // 게임결과
		String result = "DRAW";
		if ((userNumber == 1 && comNumber == 2) ||
			(userNumber == 2 && comNumber == 3) ||
			(userNumber == 3 && comNumber == 1)	) {
			result = "LOSE";
		} else if (userNumber == comNumber) {
		} else {
			result = "WIN";
		}
		return result;
	}

	
	public void showResult(int comNumber, int userNumber, String result) {
		String com;
		if (comNumber == 1)		com = "チョキ";
		else if(comNumber ==2)  com = "グー";
		else					com = "パー";
		String user = userNumber == 1 ? "チョキ" : (userNumber == 2 ? "グー" : "パー");
		System.out.printf("[COMPUTER : %2s]　[USER : %2s]　[RESULT : %s]\n", com, user, result);
	}
	
	public static void main(String[] args) {
		TheGame game = new TheGame();
		game.doGame();
	}








	
	
}
