using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_320ul_false_unsigned_long_BigInt_640ul_false_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm320ELb0EmEC2ILm640ELb0EmEERKNS0_IXT_EXT0_ET1_EE")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::BigInt<640ul, false, unsigned long>(__llvm_libc_20_1_2_::BigInt<640ul, false, unsigned long> const&)")]
	public unsafe static void Invoke(BigInt_76gxx6* @this, [NativeType("__llvm_libc_20_1_2_::BigInt<640ul, false, unsigned long> const&")] BigInt_m94xi3* other)
	{
		sbyte b = 0;
		long num = 0L;
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 40L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 5uL; num++)
			{
				long num2 = *(long*)BigInt_640ul_false_unsigned_long_Index.Invoke(other, num);
				*(long*)array_unsigned_long_5ul_Index_wu6ki8.Invoke(&@this->val, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(1L, &b);
		}
	}
}
