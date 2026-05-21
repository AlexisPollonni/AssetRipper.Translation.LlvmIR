using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_Subtract_hpqj66
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEmiERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator-(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&) const")]
	[CleanName("BigInt_64ul_false_unsigned_long_Subtract")]
	public unsafe static long Invoke(BigInt_555ggs* @this, [NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* other)
	{
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		unchecked
		{
			*(long*)(&bigInt_555ggs) = -6148914691236517206L;
			llvm_memcpy_p0_p0_i64.Invoke(&bigInt_555ggs, @this, 8L, isVolatile: false);
			BigInt_64ul_false_unsigned_long_sub_overflow.Invoke(&bigInt_555ggs, other);
			return *(long*)(&bigInt_555ggs.val.Data);
		}
	}
}
