using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_15sub_with_borrowItEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_S3_S3_RS3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, unsigned short>::type __llvm_libc_20_1_2_::sub_with_borrow<unsigned short>(unsigned short, unsigned short, unsigned short, unsigned short&)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_short_unsigned_short_type_sub_with_borrow_unsigned_short_unsigned_short_unsigned_short_unsigned_short_unsigned_short
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<short, short, short, void*, short>)(&Invoke));

	public unsafe static short Invoke(short a, short b, short carry_in, void* carry_out)
	{
		short num = 0;
		short num2 = 0;
		short num3 = 0;
		short b2 = carry_in;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = 0;
		llvm_lifetime_start_p0.Invoke(2L, &num2);
		num2 = (bool_sub_overflow_unsigned_short_unsigned_short_unsigned_short_unsigned_short.Invoke(a, b, &num) ? ((short)1) : ((short)0));
		llvm_lifetime_start_p0.Invoke(2L, &num3);
		num3 = (bool_sub_overflow_unsigned_short_unsigned_short_unsigned_short_unsigned_short.Invoke(num, b2, &num) ? ((short)1) : ((short)0));
		unchecked
		{
			*(short*)carry_out = (short)((ushort)num2 | (ushort)num3);
			short result = num;
			llvm_lifetime_end_p0.Invoke(2L, &num3);
			llvm_lifetime_end_p0.Invoke(2L, &num2);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			return result;
		}
	}
}
