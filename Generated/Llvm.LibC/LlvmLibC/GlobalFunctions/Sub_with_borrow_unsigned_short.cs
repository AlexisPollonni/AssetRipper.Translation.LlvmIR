using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sub_with_borrow_unsigned_short
{
	public unsafe static readonly void* __pointer = (delegate*<short, short, short, void*, short>)(&Invoke);

	[MangledName("_ZN19__llvm_libc_20_1_2_15sub_with_borrowItEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_S3_S3_RS3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, unsigned short>::type __llvm_libc_20_1_2_::sub_with_borrow<unsigned short>(unsigned short, unsigned short, unsigned short, unsigned short&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, unsigned short>::type")]
	public unsafe static short Invoke([MangledName("a")][NativeType("unsigned short")] short A, [MangledName("b")][NativeType("unsigned short")] short B, [MangledName("carry_in")][NativeType("unsigned short")] short Carry_in, [MangledName("carry_out")][NativeType("unsigned short&")] void* Carry_out)
	{
		short num = 0;
		short num2 = 0;
		short num3 = 0;
		short b = Carry_in;
		Llvm_lifetime_start_p0.Invoke(2L, &num);
		num = 0;
		Llvm_lifetime_start_p0.Invoke(2L, &num2);
		num2 = (Sub_overflow_unsigned_short.Invoke(A, B, &num) ? ((short)1) : ((short)0));
		Llvm_lifetime_start_p0.Invoke(2L, &num3);
		num3 = (Sub_overflow_unsigned_short.Invoke(num, b, &num) ? ((short)1) : ((short)0));
		unchecked
		{
			*(short*)Carry_out = (short)((ushort)num2 | (ushort)num3);
			short result = num;
			Llvm_lifetime_end_p0.Invoke(2L, &num3);
			Llvm_lifetime_end_p0.Invoke(2L, &num2);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			return result;
		}
	}
}
