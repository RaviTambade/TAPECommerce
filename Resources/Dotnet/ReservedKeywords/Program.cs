// See https://aka.ms/new-console-template for more information

/**

*!Reserved keywords

abstract	bool	    continue	decimal	    default
event	    explicit	extern	    char	    checked
class	    const	    break	    as	        base
delegate	is	        lock	    long	    num
byte	    case	    catch	    false	    finally
fixed	    float	    for	        as	        foreach
goto	    if	        implicit	in	        int
interface	internal	do	        double	    else
namespace	new	        null	    object	    operator
out	        override	params	    private	    protected
public	    readonly	sealed	    short	    sizeof
ref	        return	    sbyte	    stackalloc	static
string	    struct	    void	    volatile	while
true	    try	        switch	    this	    throw
unchecked	unsafe	    ushort	    using	     static
virtual	    typeof	    uint	    ulong	    out (generic modifier)

*!Contextual  keywords

add	    alias	async	await	    dynamic
from	get	    orderby	ascending	descending
group	into	join	let	        nameof
global	partial	set	    remove	    select
value	var	    when	Where	    yield
*/

Console.WriteLine("Hello, World!");

//Using enum Week

int a = (int)Week.Sunday;
int b = (int)Week.Monday;
int c = (int)Week.Tuesday;
Console.WriteLine(Week.Sunday);
Console.WriteLine(Week.Monday);
Console.WriteLine("Sunday: {0}", a);
Console.WriteLine("Monday: {0}", b);
Console.WriteLine("Tuesday: {0}", c);
Console.WriteLine("\nPress Enter Key to Exit..");
