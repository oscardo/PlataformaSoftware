import java.awt.EventQueue;

import javax.swing.JFrame;

public class jFarma extends JFrame{

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					jDistriFarma frame = new jDistriFarma();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});

	}

}
