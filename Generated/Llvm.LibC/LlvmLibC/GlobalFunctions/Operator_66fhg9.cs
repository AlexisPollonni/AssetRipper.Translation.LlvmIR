using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Operator_66fhg9
{
	[MangledName("_ZN19__llvm_libc_20_1_2_oRERNS_6BigIntILm128ELb0EmEERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::operator|=(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>&, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
	[CleanName("Operator")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("lhs")][NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>&")] Anon_izyfb7* Lhs, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] Anon_izyfb7* Rhs)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 2uL; num++)
			{
				long num2 = *(long*)BigInt_128ul_false_unsigned_long_Index_ua9ih9.Invoke(Rhs, num);
				*(long*)BigInt_128ul_false_unsigned_long_Index_4bextd.Invoke(Lhs, num) |= num2;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_memcpy_p0_p0_i64.Invoke(&bigInt_qdkjbh, Lhs, 16L, isVolatile: false);
			return *(Struct_fiz2nb*)(&bigInt_qdkjbh.Val.Data);
		}
	}
}
