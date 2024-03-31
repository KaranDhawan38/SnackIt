@ModelType List(Of FoodItem)

<main class="app-main">
    <div class="container">
        @For i As Integer = 0 To Model.Count - 1
            @<div Class="item">
                <section Class="category">
                    <article id="@Model(i).Id" Class="food-item">
                        <img src="@Model(i).ImageUrl" alt="Image">
                        <h2> @Model(i).Name</h2>
                        <div Class="counter">
                            <Button Class="button" onclick="decrement()">-</Button>
                            <div Class="value" id="counterValue">0</div>
                            <Button Class="button" onclick="increment()">+</Button>
                        </div>
                    </article>
                </section>
            </div>
        Next
    </div>
</main>
