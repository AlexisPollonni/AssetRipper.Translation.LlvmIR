using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_32ul_false_unsigned_int_RightShift
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm32ELb0EjErsEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::operator>>(unsigned long) const")]
	public unsafe static int Invoke(BigInt_vtm4cw* @this, [NativeType("unsigned long")] long s)
	{
		BigInt_vtm4cw bigInt_vtm4cw = default(BigInt_vtm4cw);
		cpp_array_2v7m9i cpp_array_2v7m9i2 = default(cpp_array_2v7m9i);
		cpp_array_2v7m9i cpp_array_2v7m9i3 = default(cpp_array_2v7m9i);
		llvm_lifetime_start_p0.Invoke(4L, &cpp_array_2v7m9i2);
		llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_2v7m9i3, &@this->val, 4L, isVolatile: false);
		unchecked
		{
			int data = multiword_shift_multiword_Direction_1_false_unsigned_int_1ul.Invoke(*(int*)(&cpp_array_2v7m9i3.Data), s);
			*(int*)(&cpp_array_2v7m9i2.Data) = data;
			BigInt_32ul_false_unsigned_int_Constructor.Invoke(&bigInt_vtm4cw, &cpp_array_2v7m9i2);
			llvm_lifetime_end_p0.Invoke(4L, &cpp_array_2v7m9i2);
			return *(int*)(&bigInt_vtm4cw.val.Data);
		}
	}
}
