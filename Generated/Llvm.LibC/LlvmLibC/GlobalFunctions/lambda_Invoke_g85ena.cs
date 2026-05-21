using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lambda_Invoke_g85ena
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_6fputil12raise_exceptEiENKUltE_clEt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::raise_except(int)::'lambda'(unsigned short)::operator()(unsigned short) const")]
	[CleanName("lambda_Invoke")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned short")] short singleExceptFlag)
	{
		fputil_internal_X87StateDescriptor fputil_internal_X87StateDescriptor2 = default(fputil_internal_X87StateDescriptor);
		int num = 0;
		short num2 = singleExceptFlag;
		llvm_lifetime_start_p0.Invoke(28L, &fputil_internal_X87StateDescriptor2);
		unchecked
		{
			*(short*)(&fputil_internal_X87StateDescriptor2) = -21846;
			((short*)(&fputil_internal_X87StateDescriptor2))[1] = -21846;
			((short*)(&fputil_internal_X87StateDescriptor2))[2] = -21846;
			((short*)(&fputil_internal_X87StateDescriptor2))[3] = -21846;
			sbyte* ptr = (sbyte*)(&fputil_internal_X87StateDescriptor2) + 8;
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			((int*)ptr)[2] = -1431655766;
			((int*)ptr)[3] = -1431655766;
			((int*)ptr)[4] = -1431655766;
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 0;
			internal_get_x87_state_descriptor.Invoke(&fputil_internal_X87StateDescriptor2);
			num = internal_get_mxcsr.Invoke();
			int num3 = (ushort)num2;
			short* ptr2 = &fputil_internal_X87StateDescriptor2.status_word;
			*ptr2 = (short)((ushort)(*ptr2) | num3);
			num |= (ushort)num2;
			internal_write_x87_state_descriptor.Invoke(&fputil_internal_X87StateDescriptor2);
			internal_write_mxcsr.Invoke(num);
			internal_fwait.Invoke();
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(28L, &fputil_internal_X87StateDescriptor2);
		}
	}
}
