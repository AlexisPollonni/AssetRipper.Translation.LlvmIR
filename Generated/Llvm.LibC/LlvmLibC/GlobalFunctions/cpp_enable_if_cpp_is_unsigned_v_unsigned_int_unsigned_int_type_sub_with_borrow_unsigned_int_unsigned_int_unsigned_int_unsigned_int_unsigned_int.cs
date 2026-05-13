using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_15sub_with_borrowIjEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_S3_S3_RS3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, unsigned int>::type __llvm_libc_20_1_2_::sub_with_borrow<unsigned int>(unsigned int, unsigned int, unsigned int, unsigned int&)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_int_unsigned_int_type_sub_with_borrow_unsigned_int_unsigned_int_unsigned_int_unsigned_int_unsigned_int
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<int, int, int, void*, int>)(&Invoke));

	public unsafe static int Invoke(int a, int b, int carry_in, void* carry_out)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = (bool_sub_overflow_unsigned_int_unsigned_int_unsigned_int_unsigned_int.Invoke(a, b, &num) ? 1 : 0);
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = (bool_sub_overflow_unsigned_int_unsigned_int_unsigned_int_unsigned_int.Invoke(num, carry_in, &num) ? 1 : 0);
		*unchecked((int*)carry_out) = num2 | num3;
		int result = num;
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
