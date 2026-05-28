using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_Float16_FPBits_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIDF16_EC2ItEET_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::FPBits<unsigned short>(unsigned short)")]
	public unsafe static void Invoke([MangledName("this")] Fputil_FPBits_2fahva* This, [MangledName("x")][NativeType("unsigned short")] short X)
	{
		short field_ = X;
		unchecked
		{
			FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_Constructor.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)This);
			((Fputil_internal_FPStorage_za9n4f*)This)->field_0 = field_;
		}
	}
}
