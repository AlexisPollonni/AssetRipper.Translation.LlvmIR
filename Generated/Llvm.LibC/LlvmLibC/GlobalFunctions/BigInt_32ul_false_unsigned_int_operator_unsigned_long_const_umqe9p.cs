using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm32ELb0EjElsEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::operator<<(unsigned long) const")]
[CleanName("BigInt_32ul_false_unsigned_int_operator_unsigned_long_const")]
internal static partial class BigInt_32ul_false_unsigned_int_operator_unsigned_long_const_umqe9p
{
	public unsafe static int Invoke(BigInt_vtm4cw* @this, long s)
	{
		BigInt_vtm4cw bigInt_vtm4cw = default(BigInt_vtm4cw);
		cpp_array_2v7m9i cpp_array_2v7m9i2 = default(cpp_array_2v7m9i);
		cpp_array_2v7m9i cpp_array_2v7m9i3 = default(cpp_array_2v7m9i);
		llvm_lifetime_start_p0.Invoke(4L, &cpp_array_2v7m9i2);
		llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_2v7m9i3, &@this->val, 4L, isVolatile: false);
		unchecked
		{
			int data = cpp_array_unsigned_int_1ul_multiword_shift_multiword_Direction_0_false_unsigned_int_1ul_cpp_array_unsigned_int_1ul_unsigned_long.Invoke(*(int*)(&cpp_array_2v7m9i3.Data), s);
			*(int*)(&cpp_array_2v7m9i2.Data) = data;
			BigInt_32ul_false_unsigned_int_BigInt_cpp_array_unsigned_int_1ul_const.Invoke(&bigInt_vtm4cw, &cpp_array_2v7m9i2);
			llvm_lifetime_end_p0.Invoke(4L, &cpp_array_2v7m9i2);
			return *(int*)(&bigInt_vtm4cw.val.Data);
		}
	}
}
