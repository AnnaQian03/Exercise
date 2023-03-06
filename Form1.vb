Public Class Form1
    Dim totalPrice As Double
    Dim tax As Double = 0.075
    Dim tax2 As Double = 7.75
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub txtPartName1_TextChanged(sender As Object, e As EventArgs) Handles txtPartName1.TextChanged

    End Sub

    Private Sub txtUnitPrice1_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNSaveOrder.Click



    End Sub

    Private Sub txtTotalParts_TextChanged(sender As Object, e As EventArgs) Handles txtTotalParts.Click
        Dim uPrice1 As Double = Val(txtUnitPrice1.Text)
        Dim uPrice2 As Double = Val(txtUnitPrice2.Text)
        Dim uPrice3 As Double = Val(txtUnitPrice3.Text)
        Dim uPrice4 As Double = Val(txtUnitPrice4.Text)
        Dim uPrice5 As Double = Val(txtUnitPrice5.Text)
        Dim quantity1 As Double = Val(txtQty1.Text)
        Dim quantity2 As Double = Val(txtQty2.Text)
        Dim quantity3 As Double = Val(txtQty3.Text)
        Dim quantity4 As Double = Val(txtQty4.Text)
        Dim quantity5 As Double = Val(txtQty5.Text)
        Dim subtotal1 As Double = Val(txtSubTotal1.Text)
        Dim subtotal2 As Double = Val(txtSubTotal2.Text)
        Dim subtotal3 As Double = Val(txtSubTotal3.Text)
        Dim subtotal4 As Double = Val(txtSubTotal4.Text)
        Dim subtotal5 As Double = Val(txtSubTotal5.Text)
        Dim price1 As Double = Val(txtPrice1.Text)
        Dim price2 As Double = Val(txtPrice2.Text)
        Dim price3 As Double = Val(txtPrice3.Text)
        Dim price4 As Double = Val(txtPrice4.Text)
        Dim price5 As Double = Val(txtPrice5.Text)
        Dim totalparts As Double = Val(txtTotalParts.Text)
        Dim totallabor As Double = Val(txtTotalLabor.Text)
        Dim taxamount As Double = Val(txtTaxAmount.Text)
        Dim totalorder As Double = Val(txtTotalOrder.Text)


        subtotal1 = uPrice1 * quantity1
        subtotal2 = uPrice2 * quantity2
        subtotal3 = uPrice3 * quantity3
        subtotal4 = uPrice4 * quantity4
        subtotal5 = uPrice5 * quantity5


        totallabor = price1 + price2 + price3 + price4 + price5
        totalparts = subtotal1 + subtotal2 + subtotal3 + subtotal4 + subtotal5

        taxamount = totalparts * tax
        totalorder = taxamount + totalparts + totallabor

        txtTotalParts.Text = totalparts.ToString("c2")
        txtTotalLabor.Text = totallabor.ToString("c2")
        txtTaxRate.Text = tax2.ToString
        txtTaxAmount.Text = taxamount.ToString("c2")
        txtTotalOrder.Text = totalorder.ToString("c2")

        txtUnitPrice1.Text = uPrice1.ToString("c2")
        txtUnitPrice2.Text = uPrice2.ToString("c2")
        txtUnitPrice3.Text = uPrice3.ToString("c2")
        txtUnitPrice4.Text = uPrice4.ToString("c2")
        txtUnitPrice5.Text = uPrice5.ToString("c2")

        txtQty1.Text = quantity1.ToString
        txtQty2.Text = quantity2.ToString
        txtQty3.Text = quantity3.ToString
        txtQty4.Text = quantity4.ToString
        txtQty5.Text = quantity5.ToString

        txtSubTotal1.Text = subtotal1.ToString("c2")
        txtSubTotal2.Text = subtotal2.ToString("c2")
        txtSubTotal3.Text = subtotal3.ToString("c2")
        txtSubTotal4.Text = subtotal4.ToString("c2")
        txtSubTotal5.Text = subtotal5.ToString("c2")

        txtPrice1.Text = price1.ToString("c2")
        txtPrice2.Text = price2.ToString("c2")
        txtPrice3.Text = price3.ToString("c2")
        txtPrice4.Text = price4.ToString("c2")
        txtPrice5.Text = price5.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Controls.Clear()
        InitializeComponent()
    End Sub
End Class
