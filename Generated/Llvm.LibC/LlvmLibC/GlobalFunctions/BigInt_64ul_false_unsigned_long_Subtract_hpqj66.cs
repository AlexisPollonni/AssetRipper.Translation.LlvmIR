using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_Subtract_hpqj66
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEmiERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator-(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&) const")]
	[CleanName("BigInt_64ul_false_unsigned_long_Subtract")]
	public unsafe static long Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_555ggs* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] Llvm_libc_20_1_2_BigInt_555ggs* Other)
	{
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs = default(Llvm_libc_20_1_2_BigInt_555ggs);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_BigInt_555ggs) = -6148914691236517206L;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_555ggs, This, 8L, isVolatile: false);
			BigInt_64ul_false_unsigned_long_sub_overflow.Invoke(&llvm_libc_20_1_2_BigInt_555ggs, Other);
			return *(long*)(&llvm_libc_20_1_2_BigInt_555ggs.Val.Data);
		}
	}
}
