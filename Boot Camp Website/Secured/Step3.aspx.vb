Public Class Step3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtOwnerName.Text = Session("Owner Name")
        txtAddress.Text = Session("Address")
        txtCity.Text = Session("City")
        txtState.Text = Session("State")
        txtZip.Text = Session("Zip")
        txtEmail.Text = Session("Email")
        txtPhoneNumber.Text = Session("Phone Number")
        txtMake.Text = Session("Make")
        txtModel.Text = Session("Model")
        txtYear.Text = Session("Year")
        txtPlateNumber.Text = Session("Plate Number")
        txtVIN.Text = Session("VIN")
        txtMileage.Text = Session("Mileage")
        txtColor.Text = Session("Color")
        txtPayment.Text = Session("Payment Type")
        txtRegistration.Text = Session("Registration Type")
        txtAgreed.Text = Session("Agree")
    End Sub

End Class