using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_anERKNS_6BigIntILm32ELb0EjEES3_")]
[DemangledName("__llvm_libc_20_1_2_::operator&(__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int> const&, __llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int> const&)")]
internal static partial class operator_BigInt_32ul_false_unsigned_int_const_BigInt_32ul_false_unsigned_int_const
{
	public unsafe static int Invoke(BigInt_vtm4cw* lhs, BigInt_vtm4cw* rhs)
	{
		BigInt_vtm4cw bigInt_vtm4cw = default(BigInt_vtm4cw);
		long num = 0L;
		unchecked
		{
			*(int*)(&bigInt_vtm4cw) = -1431655766;
			BigInt_32ul_false_unsigned_int_BigInt.Invoke(&bigInt_vtm4cw);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 1uL; num++)
			{
				int num2 = *(int*)BigInt_32ul_false_unsigned_int_operator_unsigned_long_const_w3q3b2.Invoke(lhs, num) & *(int*)BigInt_32ul_false_unsigned_int_operator_unsigned_long_const_w3q3b2.Invoke(rhs, num);
				*(int*)BigInt_32ul_false_unsigned_int_operator_unsigned_long_pb64yf.Invoke(&bigInt_vtm4cw, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(int*)(&bigInt_vtm4cw.val.Data);
		}
	}
}
