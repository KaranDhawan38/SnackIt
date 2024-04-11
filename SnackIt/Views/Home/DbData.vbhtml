@ModelType SnackIt.DbData
@Code
    ViewData("Title") = "DbData"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<br />

<h2 style="color:black">FoodItems</h2>

<table class="table" border="1">
    <tr>
        <th>Id</th>
        <th>Name</th>
        <th>Price</th>
        <th>Type</th>
        <th>Image</th>
    </tr>
    @For Each item In Model.FoodItems
        @<tr>
            <td>@item.Id</td>
            <td>@item.Name</td>
            <td>@item.Price</td>
            <td>@item.Type</td>
            <td>@item.ImageUrl</td>
        </tr>
    Next

</table>

<br />

<h2 style="color:black">Users</h2>

<table class="table" border="1">
    <tr>
        <th>Id</th>
        <th>UserName</th>
        <th>Password</th>
    </tr>
    @For Each item In Model.UsersList

        @<tr>
            <td>@item.Id</td>
            <td>@item.UserName</td>
            <td>@item.Password</td>
        </tr>
    Next

</table>


