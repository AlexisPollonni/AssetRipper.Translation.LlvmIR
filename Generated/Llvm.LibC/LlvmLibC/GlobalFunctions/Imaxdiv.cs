using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Imaxdiv
{
	[MangledName("imaxdiv")]
	[DemangledName("imaxdiv")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("x")] long X, [MangledName("y")] long Y)
	{
		Llvm_libc_20_1_2_AuxEntry llvm_libc_20_1_2_AuxEntry = default(Llvm_libc_20_1_2_AuxEntry);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_AuxEntry) = -6148914691236517206L;
			((long*)(&llvm_libc_20_1_2_AuxEntry))[1] = -6148914691236517206L;
			Llvm_libc_20_1_2_integer_rem_quo_long_g6nshs.Invoke(X, Y, &llvm_libc_20_1_2_AuxEntry.Tv_sec, &llvm_libc_20_1_2_AuxEntry.Tv_nsec);
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_AuxEntry);
		}
	}
}
