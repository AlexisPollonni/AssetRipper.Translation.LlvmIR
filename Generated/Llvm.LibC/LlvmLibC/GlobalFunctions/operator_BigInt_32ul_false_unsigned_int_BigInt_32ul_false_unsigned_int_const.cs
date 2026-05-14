using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_oRERNS_6BigIntILm32ELb0EjEERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::operator|=(__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>&, __llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int> const&)")]
internal static partial class operator_BigInt_32ul_false_unsigned_int_BigInt_32ul_false_unsigned_int_const
{
	public unsafe static int Invoke(BigInt_vtm4cw* lhs, BigInt_vtm4cw* rhs)
	{
		BigInt_vtm4cw bigInt_vtm4cw = default(BigInt_vtm4cw);
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 1uL; num++)
			{
				int num2 = *(int*)BigInt_32ul_false_unsigned_int_operator_unsigned_long_const_w3q3b2.Invoke(rhs, num);
				*(int*)BigInt_32ul_false_unsigned_int_operator_unsigned_long_pb64yf.Invoke(lhs, num) |= num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_memcpy_p0_p0_i64.Invoke(&bigInt_vtm4cw, lhs, 4L, isVolatile: false);
			return *(int*)(&bigInt_vtm4cw.val.Data);
		}
	}
}
