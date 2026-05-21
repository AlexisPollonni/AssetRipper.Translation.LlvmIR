using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_512ul_false_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm512ELb0EmEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<512ul, false, unsigned long>::BigInt()")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_fjg8pd* This)
	{
		Llvm_memset_p0_i64.Invoke(&This->Val.Data, 0, 64L, isVolatile: false);
	}
}
