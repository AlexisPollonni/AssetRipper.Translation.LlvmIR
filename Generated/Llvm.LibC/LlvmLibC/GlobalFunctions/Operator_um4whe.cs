using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Operator_um4whe
{
	[MangledName("_ZN19__llvm_libc_20_1_2_oRERNS_6BigIntILm64ELb0EmEERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::operator|=(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>&, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
	[CleanName("Operator")]
	public unsafe static long Invoke([NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>&")] BigInt_555ggs* lhs, [NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* rhs)
	{
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 1uL; num++)
			{
				long num2 = *(long*)BigInt_64ul_false_unsigned_long_Index_64yjsu.Invoke(rhs, num);
				*(long*)BigInt_64ul_false_unsigned_long_Index_6xqgif.Invoke(lhs, num) |= num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_memcpy_p0_p0_i64.Invoke(&bigInt_555ggs, lhs, 8L, isVolatile: false);
			return *(long*)(&bigInt_555ggs.val.Data);
		}
	}
}
