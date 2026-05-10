using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_anERKNS_6BigIntILm16ELb0EtEES3_")]
[DemangledName("__llvm_libc_20_1_2_::operator&(__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short> const&, __llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short> const&)")]
internal static partial class operator_BigInt_16ul_false_unsigned_short_const_BigInt_16ul_false_unsigned_short_const
{
	public unsafe static short Invoke(void* lhs, void* rhs)
	{
		BigInt_ys7s55 bigInt_ys7s = default(BigInt_ys7s55);
		long num = 0L;
		unchecked
		{
			*(short*)(&bigInt_ys7s) = -21846;
			BigInt_16ul_false_unsigned_short_BigInt.Invoke(&bigInt_ys7s);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 1uL; num++)
			{
				short num2 = (short)((ushort)(*(short*)BigInt_16ul_false_unsigned_short_operator_unsigned_long_const_z52e5b.Invoke(lhs, num)) & (ushort)(*(short*)BigInt_16ul_false_unsigned_short_operator_unsigned_long_const_z52e5b.Invoke(rhs, num)));
				*(short*)BigInt_16ul_false_unsigned_short_operator_unsigned_long_frmhnq.Invoke(&bigInt_ys7s, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(short*)(&bigInt_ys7s.val.Data);
		}
	}
}
