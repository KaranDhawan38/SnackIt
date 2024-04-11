@ModelType IEnumerable(Of SnackIt.CartItem)
@Code
    ViewData("Title") = "Cart"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Cart</h2>

<table class="table" id="myTable">
    <tr>
        <th>

        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CartValue)
        </th>
        <th>
            Item Price
        </th>
        <th>
           Total Price
        </th>
    </tr>

    @For Each item In Model
        @<tr>
    <td>
        <img src="@item.ImageUrl" alt="Food Image" style="width:64px" />
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Name)
    </td>
    <td>
        <b>
            @Html.DisplayFor(Function(modelItem) item.CartValue)
        </b>
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Price) x @Html.DisplayFor(Function(modelItem) item.CartValue)
    </td>
    <td>
        @Code
            Dim totalPrice = item.Price * item.CartValue
        End Code
        @totalPrice
    </td>
</tr>
            Next
<tr>
    <td></td>
    <td></td>
    <td></td>
    <td><b>Total to Pay = Rs</b></td>
    <td id="total"></td>
</tr>
</table>
