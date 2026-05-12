using System;

namespace LlvmLibC.Helpers;

internal static partial class AssemblyFunctions
{
	[InlineAssembly("fnstenv $0", "=*m,~{dirflag},~{fpsr},~{flags}")]
	public unsafe static void M0(void* P_0)
	{
		throw new NotImplementedException("Inline assembly not supported: fnstenv $0");
	}

	[InlineAssembly("stmxcsr $0", "=*m,~{dirflag},~{fpsr},~{flags}")]
	public unsafe static void M1(int* P_0)
	{
		throw new NotImplementedException("Inline assembly not supported: stmxcsr $0");
	}

	[InlineAssembly("fldenv $0", "*m,~{dirflag},~{fpsr},~{flags}")]
	public unsafe static void M2(void* P_0)
	{
		throw new NotImplementedException("Inline assembly not supported: fldenv $0");
	}

	[InlineAssembly("ldmxcsr $0", "*m,~{dirflag},~{fpsr},~{flags}")]
	public unsafe static void M3(int* P_0)
	{
		throw new NotImplementedException("Inline assembly not supported: ldmxcsr $0");
	}

	[InlineAssembly("fwait", "~{dirflag},~{fpsr},~{flags}")]
	public static void M4()
	{
		throw new NotImplementedException("Inline assembly not supported: fwait");
	}

	[InlineAssembly("fsqrt", "={st},0,~{dirflag},~{fpsr},~{flags}")]
	public static double M5(double P_0)
	{
		throw new NotImplementedException("Inline assembly not supported: fsqrt");
	}

	[InlineAssembly("sqrtss ${1:x}, ${0:x}", "=x,x,~{dirflag},~{fpsr},~{flags}")]
	public static float M6(float P_0)
	{
		throw new NotImplementedException("Inline assembly not supported: sqrtss ${1:x}, ${0:x}");
	}

	[InlineAssembly("sqrtsd ${1:x}, ${0:x}", "=x,x,~{dirflag},~{fpsr},~{flags}")]
	public static double M7(double P_0)
	{
		throw new NotImplementedException("Inline assembly not supported: sqrtsd ${1:x}, ${0:x}");
	}

	[InlineAssembly("fnstsw $0", "=*m,~{dirflag},~{fpsr},~{flags}")]
	public unsafe static void M8(short* P_0)
	{
		throw new NotImplementedException("Inline assembly not supported: fnstsw $0");
	}

	[InlineAssembly("fnstcw $0", "=*m,~{dirflag},~{fpsr},~{flags}")]
	public unsafe static void M9(short* P_0)
	{
		throw new NotImplementedException("Inline assembly not supported: fnstcw $0");
	}

	[InlineAssembly("fldcw $0", "*m,~{dirflag},~{fpsr},~{flags}")]
	public unsafe static void M10(short* P_0)
	{
		throw new NotImplementedException("Inline assembly not supported: fldcw $0");
	}

	[InlineAssembly("syscall", "={ax},{ax},{di},{si},{dx},~{rcx},~{r11},~{memory},~{dirflag},~{fpsr},~{flags}")]
	public static long M11(long P_0, long P_1, long P_2, long P_3)
	{
		throw new NotImplementedException("Inline assembly not supported: syscall");
	}

	[InlineAssembly("syscall", "={ax},{ax},{di},~{rcx},~{r11},~{memory},~{dirflag},~{fpsr},~{flags}")]
	public static long M12(long P_0, long P_1)
	{
		throw new NotImplementedException("Inline assembly not supported: syscall");
	}

	[InlineAssembly("syscall", "={ax},{ax},{di},{si},~{rcx},~{r11},~{memory},~{dirflag},~{fpsr},~{flags}")]
	public static long M13(long P_0, long P_1, long P_2)
	{
		throw new NotImplementedException("Inline assembly not supported: syscall");
	}

	[InlineAssembly("syscall", "={ax},{ax},{di},{si},{dx},{r10},~{rcx},~{r11},~{memory},~{dirflag},~{fpsr},~{flags}")]
	public static long M14(long P_0, long P_1, long P_2, long P_3, long P_4)
	{
		throw new NotImplementedException("Inline assembly not supported: syscall");
	}

	[InlineAssembly("syscall", "={ax},{ax},{di},{si},{dx},{r10},{r8},~{rcx},~{r11},~{memory},~{dirflag},~{fpsr},~{flags}")]
	public static long M15(long P_0, long P_1, long P_2, long P_3, long P_4, long P_5)
	{
		throw new NotImplementedException("Inline assembly not supported: syscall");
	}

	[InlineAssembly("syscall", "={ax},{ax},~{rcx},~{r11},~{memory},~{dirflag},~{fpsr},~{flags}")]
	public static long M16(long P_0)
	{
		throw new NotImplementedException("Inline assembly not supported: syscall");
	}

	[InlineAssembly("syscall", "={ax},{ax},{di},{si},{dx},{r10},{r8},{r9},~{rcx},~{r11},~{memory},~{dirflag},~{fpsr},~{flags}")]
	public static long M17(long P_0, long P_1, long P_2, long P_3, long P_4, long P_5, long P_6)
	{
		throw new NotImplementedException("Inline assembly not supported: syscall");
	}

	[InlineAssembly("", "r,~{memory},~{dirflag},~{fpsr},~{flags}")]
	public unsafe static void M18(void* P_0)
	{
		throw new NotImplementedException("Inline assembly not supported: ");
	}
}
