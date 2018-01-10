import java.awt.BorderLayout;
import java.awt.EventQueue;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.SwingConstants;
import java.awt.Font;
import java.awt.*;

import javax.swing.ButtonGroup;
import javax.swing.JTextField;
import javax.swing.JComboBox;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JRadioButton;
import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;
import javax.swing.LayoutStyle.ComponentPlacement;
import javax.swing.JCheckBox;
import javax.swing.JButton;
import javax.swing.*;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.io.Console;

public class jDistriFarma extends JFrame {
	private String Farmacia;
	private int opcFarmacia;
	private String Medicamento;
	private int Cantidad;
	private String Distribuidor = "";
	private String TipoMedicamento = "";
	
	private JPanel contentPane;
	private JTextField txtMedicamento;
	private JTextField txtCantidad;
	private JComboBox cbTipoMedicamento;
	private JRadioButton rbDistribuidor1;
	private JRadioButton rbDistribuidor2;
	private JRadioButton rbDistribuidor3;
	private JCheckBox chFarmarciaPrincipal;
	private JCheckBox chFarmarciaSecundaria;
	private JButton btnBuscarInformacin;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	/**
	 * Create the frame.
	 */
	
	
	public jDistriFarma(){
	
		setTitle("DistriFarma S.A.S");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 407, 568);
		contentPane = new JPanel();
		contentPane.setToolTipText("Escoge una de las tres opciones ");
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		
		JLabel lblMedicamento = new JLabel("Nombre del Medicamento");
		lblMedicamento.setFont(new Font("Tahoma", Font.PLAIN, 16));
		lblMedicamento.setHorizontalAlignment(SwingConstants.CENTER);
		
		txtMedicamento = new JTextField();
		txtMedicamento.setFont(new Font("Tahoma", Font.PLAIN, 16));
		txtMedicamento.setColumns(10);
		
		JLabel lblCantidad = new JLabel("Cantidad");
		lblCantidad.setHorizontalAlignment(SwingConstants.CENTER);
		lblCantidad.setFont(new Font("Tahoma", Font.PLAIN, 16));
		
		txtCantidad = new JTextField();
		txtCantidad.setHorizontalAlignment(SwingConstants.CENTER);
		txtCantidad.setFont(new Font("Tahoma", Font.PLAIN, 16));
		txtCantidad.setColumns(10);
		
		JLabel lblTipoMedicamento = new JLabel("Tipo Medicamento");
		lblTipoMedicamento.setHorizontalAlignment(SwingConstants.CENTER);
		lblTipoMedicamento.setFont(new Font("Tahoma", Font.PLAIN, 16));
		
		//JComboBox cbTipoMedicamento = new JComboBox();
		cbTipoMedicamento = new JComboBox();
		cbTipoMedicamento.setModel(new DefaultComboBoxModel(new String[] {"analg\u00E9sico", "anal\u00E9ptico", "anest\u00E9sico", "anti\u00E1cido", "antidepresivo", "antibi\u00F3ticos"}));
		cbTipoMedicamento.setFont(new Font("Tahoma", Font.PLAIN, 16));
		
		JLabel lblDistribuidor = new JLabel("Distribuidor farmac\u00E9utico");
		lblDistribuidor.setHorizontalAlignment(SwingConstants.CENTER);
		lblDistribuidor.setFont(new Font("Tahoma", Font.PLAIN, 16));
		
		rbDistribuidor1 = new JRadioButton("Cofarma");
		buttonGroup.add(rbDistribuidor1);
		rbDistribuidor1.setToolTipText("Escoge una de las tres opciones ");
		rbDistribuidor1.setFont(new Font("Tahoma", Font.PLAIN, 16));
		
		rbDistribuidor2 = new JRadioButton("Empsephar ");
		buttonGroup.add(rbDistribuidor2);
		rbDistribuidor2.setToolTipText("Escoge una de las tres opciones ");
		rbDistribuidor2.setFont(new Font("Tahoma", Font.PLAIN, 16));
		
		rbDistribuidor3 = new JRadioButton("Cemefar");
		buttonGroup.add(rbDistribuidor3);
		rbDistribuidor3.setToolTipText("Escoge una de las tres opciones ");
		rbDistribuidor3.setFont(new Font("Tahoma", Font.PLAIN, 16));
		
		JLabel lblSucursal = new JLabel("Sucursal ");
		lblSucursal.setHorizontalAlignment(SwingConstants.CENTER);
		lblSucursal.setFont(new Font("Tahoma", Font.PLAIN, 16));
		
		chFarmarciaPrincipal = new JCheckBox("Famarcia Principal");
		chFarmarciaPrincipal.setFont(new Font("Tahoma", Font.PLAIN, 16));
		
		chFarmarciaSecundaria = new JCheckBox("Famarcia Secundaria");
		chFarmarciaSecundaria.setFont(new Font("Tahoma", Font.PLAIN, 16));
		
		btnBuscarInformacin = new JButton("Buscar Informaci\u00F3n");
		btnBuscarInformacin.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if(DatosBusqueda() == true){
					//llevar_pedido(Medicamento, Cantidad, Distribuidor, TipoMedicamento, Famacia, opcFarmacia);
					Pedido ped = new Pedido();
					ped.llevar_pedido(Medicamento, Cantidad, Distribuidor, TipoMedicamento, Farmacia, opcFarmacia);
					ped.setLocation(500, 200);
					ped.setVisible(true);
				}
			}
		});
		
		btnBuscarInformacin.setFont(new Font("Tahoma", Font.BOLD, 14));
		JButton btnBorrar = new JButton("Borrar");
		btnBorrar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				Utils util = new Utils();
				int valor = util.Mensaje("Desea borrar el formato", "DistriFarma", 1);
				if(valor == 0){
					Borrar();
				}
			}
		});
		btnBorrar.setFont(new Font("Tahoma", Font.BOLD, 14));
		GroupLayout gl_contentPane = new GroupLayout(contentPane);
		gl_contentPane.setHorizontalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(7)
							.addComponent(lblMedicamento, GroupLayout.PREFERRED_SIZE, 322, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(3)
							.addComponent(rbDistribuidor1, GroupLayout.PREFERRED_SIZE, 127, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(3)
							.addComponent(rbDistribuidor2, GroupLayout.PREFERRED_SIZE, 127, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(3)
							.addComponent(rbDistribuidor3, GroupLayout.PREFERRED_SIZE, 127, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addContainerGap()
							.addComponent(lblSucursal, GroupLayout.PREFERRED_SIZE, 322, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addContainerGap()
							.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
								.addComponent(chFarmarciaPrincipal, GroupLayout.DEFAULT_SIZE, 657, Short.MAX_VALUE)
								.addGroup(gl_contentPane.createParallelGroup(Alignment.TRAILING, false)
									.addGroup(Alignment.LEADING, gl_contentPane.createSequentialGroup()
										.addComponent(btnBuscarInformacin)
										.addPreferredGap(ComponentPlacement.RELATED)
										.addComponent(btnBorrar, GroupLayout.DEFAULT_SIZE, GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
									.addComponent(chFarmarciaSecundaria, Alignment.LEADING, GroupLayout.PREFERRED_SIZE, 313, GroupLayout.PREFERRED_SIZE))))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addContainerGap()
							.addGroup(gl_contentPane.createParallelGroup(Alignment.TRAILING)
								.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
									.addComponent(lblCantidad, GroupLayout.PREFERRED_SIZE, 322, GroupLayout.PREFERRED_SIZE)
									.addComponent(txtCantidad, GroupLayout.PREFERRED_SIZE, 322, GroupLayout.PREFERRED_SIZE))
								.addComponent(lblDistribuidor, GroupLayout.PREFERRED_SIZE, 322, GroupLayout.PREFERRED_SIZE)))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addContainerGap()
							.addGroup(gl_contentPane.createParallelGroup(Alignment.TRAILING)
								.addComponent(lblTipoMedicamento, GroupLayout.PREFERRED_SIZE, 322, GroupLayout.PREFERRED_SIZE)
								.addComponent(txtMedicamento, GroupLayout.PREFERRED_SIZE, 322, GroupLayout.PREFERRED_SIZE))))
					.addGap(823))
				.addGroup(gl_contentPane.createSequentialGroup()
					.addContainerGap()
					.addComponent(cbTipoMedicamento, GroupLayout.PREFERRED_SIZE, 322, GroupLayout.PREFERRED_SIZE)
					.addContainerGap(860, Short.MAX_VALUE))
		);
		gl_contentPane.setVerticalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addGap(8)
					.addComponent(lblMedicamento, GroupLayout.PREFERRED_SIZE, 26, GroupLayout.PREFERRED_SIZE)
					.addComponent(txtMedicamento, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
					.addPreferredGap(ComponentPlacement.UNRELATED)
					.addComponent(lblTipoMedicamento, GroupLayout.PREFERRED_SIZE, 26, GroupLayout.PREFERRED_SIZE)
					.addPreferredGap(ComponentPlacement.RELATED)
					.addComponent(cbTipoMedicamento, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
					.addGap(19)
					.addComponent(lblCantidad, GroupLayout.PREFERRED_SIZE, 26, GroupLayout.PREFERRED_SIZE)
					.addComponent(txtCantidad, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
					.addPreferredGap(ComponentPlacement.UNRELATED)
					.addComponent(lblDistribuidor, GroupLayout.PREFERRED_SIZE, 26, GroupLayout.PREFERRED_SIZE)
					.addGap(9)
					.addComponent(rbDistribuidor1, GroupLayout.PREFERRED_SIZE, 25, GroupLayout.PREFERRED_SIZE)
					.addGap(5)
					.addComponent(rbDistribuidor2, GroupLayout.PREFERRED_SIZE, 25, GroupLayout.PREFERRED_SIZE)
					.addGap(7)
					.addComponent(rbDistribuidor3, GroupLayout.PREFERRED_SIZE, 25, GroupLayout.PREFERRED_SIZE)
					.addPreferredGap(ComponentPlacement.RELATED)
					.addComponent(lblSucursal, GroupLayout.PREFERRED_SIZE, 26, GroupLayout.PREFERRED_SIZE)
					.addPreferredGap(ComponentPlacement.RELATED)
					.addComponent(chFarmarciaPrincipal)
					.addPreferredGap(ComponentPlacement.UNRELATED)
					.addComponent(chFarmarciaSecundaria, GroupLayout.PREFERRED_SIZE, 29, GroupLayout.PREFERRED_SIZE)
					.addPreferredGap(ComponentPlacement.UNRELATED)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.BASELINE)
						.addComponent(btnBuscarInformacin)
						.addComponent(btnBorrar))
					.addContainerGap(119, Short.MAX_VALUE))
		);
		contentPane.setLayout(gl_contentPane);
	}
	
	private boolean DatosBusqueda(){
		boolean rpt = false;
		Utils util = new Utils();
		if(txtMedicamento.getText().isEmpty()){
    		util.Mensaje("No debe estar vacio", "Nombre Medicamento", 3);
            return rpt;
    	}
	    else if(txtMedicamento.getText().length() > 50){
	    	util.Mensaje("Máximo hasta 50 carácteres", "Nombre Medicamento", 3);
            return rpt;
	    }
	    else{
	    	Medicamento = txtMedicamento.getText();
	    }
	    
	    try {
	    	Cantidad = Integer.parseInt(txtCantidad.getText());
	    	Cantidad = Math.abs(Cantidad);
	    	if(Cantidad >= 99){
	    		util.Mensaje("Debe seleccionar entre 1 y 99 árticulos", "Cantidad", 3);
                return rpt;
	    	}
	    	if(cbTipoMedicamento.getSelectedIndex() == -1){
	    		util.Mensaje("Debe seleccionar un tipo de medicamento", "Tipo de Medicamento", 1);
                return rpt;
	    	}
	    	
	    	if(rbDistribuidor1.isSelected() == false && 
	    			rbDistribuidor2.isSelected() == false &&
	    			rbDistribuidor3.isSelected() == false){
	                 util.Mensaje("Debe seleccionar un distribuidor", "Distribuidor", 3);
	                 return rpt;
	        }
	    	if(rbDistribuidor1.isSelected()) Distribuidor = rbDistribuidor1.getText();
	    	if(rbDistribuidor2.isSelected()) Distribuidor = rbDistribuidor2.getText();
	    	if(rbDistribuidor3.isSelected()) Distribuidor = rbDistribuidor3.getText();
	
	    	if(chFarmarciaPrincipal.isSelected() == false && chFarmarciaSecundaria.isSelected() == false){
	            util.Mensaje("Debe seleccionar alguna farmacia", "Farmacia", 3);
	
	            return rpt;
	        }else if(chFarmarciaPrincipal.isSelected() == true && chFarmarciaSecundaria.isSelected() == false){
	            Farmacia = "Farmacia Principal";
	            opcFarmacia = 1;
	        }else if(chFarmarciaPrincipal.isSelected() == false && chFarmarciaSecundaria.isSelected() == true){
	            Farmacia = "Farmacia Secundaria";
	            opcFarmacia = 2;
	        }else{
	            Farmacia = "Farmacia Principal y Secundaria";
	            opcFarmacia = 3;
	        }
	    	TipoMedicamento = String.valueOf(cbTipoMedicamento.getSelectedItem());
	    	//String mensaje = Medicamento + " - " + Cantidad + " - " + Distribuidor + " - " + Farmacia ;
	    	//util.Mensaje(mensaje);
	    	rpt = true;
	    } catch (Exception e) {
	    	e.printStackTrace();
	    	util.Mensaje(" Error: " + e.getStackTrace().toString());
	    	rpt = false;
		}
	    return rpt;
	}
	
	private void Borrar(){
		txtCantidad.setText("");
		txtMedicamento.setText("");
		cbTipoMedicamento.setSelectedIndex(-1);
		rbDistribuidor1.setSelected(true);
		rbDistribuidor2.setSelected(false);
		rbDistribuidor3.setSelected(false);
		buttonGroup.setSelected(null, false);
		chFarmarciaPrincipal.setSelected(false);
		chFarmarciaSecundaria.setSelected(false);
	}
	
	/**
    *
    *   «Pedido al distribuidor D» donde D es el distribuidor seleccionado previamente. Esto aparecerá como el título de la ventana (JFrame).
    *   Texto con el medicamento a pedir: «X unidades del T M» donde X es el número de unidades, T es el tipo de medicamento y M el nombre el medicamento (JLabel). Por ejemplo: 10 unidades del antibiótico amoxicilina.
    *   Texto con la dirección de la farmacia a donde enviarlo: «Para la farmacia situada en D» donde D es la dirección de la farmacia (JLabel). Para la farmacia Principal la dirección es Calle de la Rosa n. 28 para la secundaria es Calle Alcazabilla n. 3. Por ejemplo: «Para la farmacia situada en Calle de la Rosa n.28 y para la situada en Calle Alcazabilla n.3».
    *   Además, esta segunda ventana contendrá dos botones (ambos JButton) uno para cancelar el pedido, que cierra la ventana y otro para enviar el pedido. Este envío de pedido lo simularemos con un mensaje por pantalla «System.out.println» («Pedido enviado»).
    *   
    * @param Dato_NombreMedicamento
    * @param Dato_Cantidad
    * @param Dato_Distribuidor
    * @param Dato_TipoMedicamento
    * @param Dato_Famacia
    * @param opcionFarmacia
    */
   /*
	public void llevar_pedido(String Dato_NombreMedicamento, int Dato_Cantidad, String Dato_Distribuidor, String Dato_TipoMedicamento, String Dato_Farmacia, int opcionFarmacia){
       String NombreMedicamento = Dato_NombreMedicamento;
       int Cantidad = Dato_Cantidad;
       String Distribuidor = Dato_Distribuidor;
       String TipoMedicamento = Dato_TipoMedicamento;
       String Farmacia = Dato_Farmacia;
       
       Pedido.setText("Pedido al distribuidor: " + Distribuidor);
       String unidades = String.valueOf(Dato_Cantidad) + " Unidades del tipo " + TipoMedicamento + " de " + NombreMedicamento;
       jlbMedicamento.setText(unidades);
       
       String direccion = "";
       switch(opcionFarmacia)
       {
           case 1: direccion = "Para la farmacia situada en Calle de la Rosa n. 28"; break;
           case 2: direccion = "Para la farmacia situada en Calle Alcazabilla n. 3."; break;
           case 3: direccion = "Para la farmacia situada en las Calle de la Rosa n. 28 y para la situada en Calle Alcazabilla n. 3."; break;
           default: direccion = "Para la farmacia situada en las Calle de la Rosa n. 28 y para la situada en Calle Alcazabilla n. 3."; break;
       }
       jlbSucursal.setText(direccion);
       
   }
   */
   
	/*
	if(jtxtNombreMedicamento.getText().isEmpty() == true){
        util.Mensaje("No debe estar vacio", "Nombre Medicamento", 3);
        return rpt;
    }
if(jtxtNombreMedicamento.getText().length() >= 30){
        util.Mensaje("No se permite un medicamento con esa extensión, máximo son 30 caractéres", "Nombre Medicamento", 3);
        return rpt;
    }
try {
    if(jtxtCantidad.getText().isEmpty() == true){
        util.Mensaje("No debe estar vacio", "Cantidad", 3);
        return rpt;
    }
    Cantidad = Integer.parseInt(jtxtCantidad.getText());
    Cantidad = Math.abs(Cantidad);
    
    if(jcbTipoMedicamento.getSelectedIndex() == -1){
        util.Mensaje("Debe seleccionar algún valor", "Tipo de Medicamento", 3);
        return rpt;
    }
    if(jrbDistribuidor1.isSelected() == false && 
       jrbDistribuidor2.isSelected() == false &&
       jrbDistribuidor3.isSelected() == false){
        util.Mensaje("Debe seleccionar un distribuidor", "Distribuidor", 3);
        return rpt;
    }
    
    if(jrbDistribuidor1.isSelected()) Distribuidor = jrbDistribuidor1.getText();
    if(jrbDistribuidor2.isSelected()) Distribuidor = jrbDistribuidor2.getText();
    if(jrbDistribuidor3.isSelected()) Distribuidor = jrbDistribuidor3.getText();
    
    if(jckFamaciaPrincipal.isSelected() == false && jckFamaciaSecundaria.isSelected() == false){
        util.Mensaje("Debe seleccionar alguna farmacia", "Farmacia", 3);
        return rpt;
    }else if(jckFamaciaPrincipal.isSelected() == true && jckFamaciaSecundaria.isSelected() == false){
        Famacia = "Farmacia Principal";
        opcFarmacia = 1;
    }else if(jckFamaciaPrincipal.isSelected() == false && jckFamaciaSecundaria.isSelected() == true){
        Famacia = "Farmacia Secundaria";
        opcFarmacia = 2;
    }else{
        Famacia = "Farmacia Principal y Secundaria";
        opcFarmacia = 3;
    }
    
    NombreMedicamento = jtxtNombreMedicamento.getText();
    TMedicamento = jcbTipoMedicamento.getSelectedItem();
    TipoMedicamento = String.valueOf(TMedicamento);
    rpt = true;
    
    } catch (Exception e) {
        System.err.print("Error: " + e.getMessage() + " - StackTrace: " + e.getStackTrace().toString());
        JOptionPane.showConfirmDialog(this, "Se ha cometido un error en la conversión de cadena a números");
        rpt = false;
        return rpt;
    }
	return rpt;
	*/
}
