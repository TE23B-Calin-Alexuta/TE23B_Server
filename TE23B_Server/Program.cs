WebApplication app = WebApplication.Create(args);

List<Elev> elever = [
    new() {Name = "Aris", Subject = "Prg", Wage = 0},
    new() {Name = "Renat", Subject = "Rus", Wage = 10},
    new() {Name = "Alex", Subject = "Rom", Wage = -523587}
];





app.MapGet("/",Hello);
app.MapGet("/calin", Calin);
app.MapGet("/elev", GimmeElev);
app.MapGet("/elev/{n}", GimmeOneElev);

app.Run();


List<Elev> GimmeElev()
{

    return elever;
}

IResult GimmeOneElev(int n)
{
    if (n < 0 || n >= elever.Count)
    {
        return Results.NotFound();
    }

    return Results.Ok(elever[n]);
}
static string Hello()
{
    return "Hello TE23B";
}

static string Calin()
{
    return "Världens bästa elev";
}