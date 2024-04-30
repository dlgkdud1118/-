import java.io.Serializable;
import java.text.SimpleDateFormat;
import java.util.Date;


public class GameResult implements Serializable{

	private static int nextNo = 1;
	public static int getNextNo() { 
		return nextNo;
	}
	public static void setNextNo(int nextNo) {
		GameResult.nextNo = nextNo;
	}
	
	private int no;
	private Date gameDate;
	private int comNo;
	private int userNo;
	private String result;
	
	public GameResult() { 
		this.no = nextNo;
		nextNo++;
	}
	public GameResult(int no, Date gameDate, int comNo, int userNo, String result) {
		this();
		this.gameDate = gameDate;
		this.comNo = comNo;
		this.userNo = userNo;
		this.result = result;
	}
	
	public int getNo() { 
		return no;
	}
	public void setNo(int no) {
		this.no = no;
	}
	public Date getGameDate() {
		return gameDate;
	}
	public int getComNo() { 
		return comNo;
	}
	public void setComNo(int comNo) {
		this.comNo = comNo;
	}
	public int getUserNo() {
		return userNo;
	}
	public void setUserNo(int userNo) {
		this.userNo = userNo;
	}
	public String getResult() {
		return result;
	}
	public void setResult(String result) {
		this.result = result;
	}
	
	@Override
	public String toString() {
		SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd a hh:mm:ss");
		return String.format("[%05d][%s][%d][%d][%s]",no, sdf.format(gameDate), comNo, userNo, result);
	}
	
	String etc = null;
	
}
