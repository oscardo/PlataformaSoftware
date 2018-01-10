
import javax.swing.JOptionPane;


/**
 *
 * @author Oscardo
 */
public class Utils {
    JOptionPane Panel;
    Utils(){
        Panel = new JOptionPane();
    }
    
    public int Mensaje(String mensaje){
        int rpt = Panel.showConfirmDialog(null, mensaje);
        return rpt;
    }
    
    //DEFAULT_OPTION
    //YES_NO_OPTION
    //YES_NO_CANCEL_OPTION
    //OK_CANCEL_OPTION
   /**
   * Mensaje
   * @param nro 1 = YES_NO_OPTION,
   *            2 = YES_NO_CANCEL_OPTION,
   *            3 = WARNING_MESSAGE
   *            
   */
    public int Mensaje(String mensaje, String titulo, int nro){
        int val = 0; 
        switch(nro){
            case 1: val =  JOptionPane.YES_NO_OPTION; break;
            case 2: val =  JOptionPane.YES_NO_CANCEL_OPTION; break;
            case 3: val =  JOptionPane.WARNING_MESSAGE; break;
        }
        int rpt = Panel.showConfirmDialog(null, mensaje, titulo, val);
        return rpt;
    }
}



