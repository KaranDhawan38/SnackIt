@ModelType List(Of FoodItem)
<main class="app-main">
    @For i As Integer = 0 To Model.Count
        @<section Class="category">
            @For j As Integer = 0 To 3
                @<article id="@Model(i).Id" Class="food-item">
                    <img src="@Model(i).ImageUrl" alt="Image">
                    <h2> @Model(i).Name</h2>
                </article>
                i = i + 1
                If i = Model.Count Then
                    Exit For
                End If
            Next
        </section>
    Next
</main>
