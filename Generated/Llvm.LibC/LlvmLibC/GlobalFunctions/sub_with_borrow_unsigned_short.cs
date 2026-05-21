using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sub_with_borrow_unsigned_short
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<short, short, short, void*, short>)(&Invoke));

	[MangledName("_ZN19__llvm_libc_20_1_2_15sub_with_borrowItEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_S3_S3_RS3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, unsigned short>::type __llvm_libc_20_1_2_::sub_with_borrow<unsigned short>(unsigned short, unsigned short, unsigned short, unsigned short&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, unsigned short>::type")]
	public unsafe static short Invoke([NativeType("unsigned short")] short a, [NativeType("unsigned short")] short b, [NativeType("unsigned short")] short carry_in, [NativeType("unsigned short&")] void* carry_out)
	{
		short num = 0;
		short num2 = 0;
		short num3 = 0;
		short b2 = carry_in;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = 0;
		llvm_lifetime_start_p0.Invoke(2L, &num2);
		num2 = (sub_overflow_unsigned_short.Invoke(a, b, &num) ? ((short)1) : ((short)0));
		llvm_lifetime_start_p0.Invoke(2L, &num3);
		num3 = (sub_overflow_unsigned_short.Invoke(num, b2, &num) ? ((short)1) : ((short)0));
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
