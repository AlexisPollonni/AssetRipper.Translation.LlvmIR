using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sysconf
{
	[MangledName("sysconf")]
	[DemangledName("sysconf")]
	public unsafe static long Invoke([MangledName("name")] int Name)
	{
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		long result;
		if (Name == 30)
		{
			result = unchecked((delegate*<long, long>)Getauxval.__pointer)(6L);
		}
		else if (num < 0L)
		{
			Errno_Assignment.Invoke(Llvm_libc_20_1_2_libc_errno.Pointer, 22);
			result = -1L;
		}
		else
		{
			result = num;
		}
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
