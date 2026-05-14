using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_anERKNS_6BigIntILm64ELb0EmEES3_")]
[DemangledName("__llvm_libc_20_1_2_::operator&(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
[CleanName("operator_BigInt_64ul_false_unsigned_long_const_BigInt_64ul_false_unsigned_long_const")]
internal static partial class operator_BigInt_64ul_false_unsigned_long_const_BigInt_64ul_false_unsigned_long_const_ufy43f
{
	public unsafe static long Invoke(BigInt_555ggs* lhs, BigInt_555ggs* rhs)
	{
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		long num = 0L;
		unchecked
		{
			*(long*)(&bigInt_555ggs) = -6148914691236517206L;
			BigInt_64ul_false_unsigned_long_BigInt.Invoke(&bigInt_555ggs);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 1uL; num++)
			{
				long num2 = *(long*)BigInt_64ul_false_unsigned_long_operator_unsigned_long_const_64yjsu.Invoke(lhs, num) & *(long*)BigInt_64ul_false_unsigned_long_operator_unsigned_long_const_64yjsu.Invoke(rhs, num);
				*(long*)BigInt_64ul_false_unsigned_long_operator_unsigned_long_kztvyk.Invoke(&bigInt_555ggs, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(long*)(&bigInt_555ggs.val.Data);
		}
	}
}
