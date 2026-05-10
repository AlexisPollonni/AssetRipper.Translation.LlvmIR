using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_6fputil12raise_exceptEiENKUltE_clEt")]
[DemangledName("__llvm_libc_20_1_2_::fputil::raise_except(int)::'lambda'(unsigned short)::operator()(unsigned short) const")]
internal static partial class fputil_raise_except_int_lambda_unsigned_short_operator_unsigned_short_const
{
	public unsafe static void Invoke(void* @this, short singleExceptFlag)
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
			fputil_internal_get_x87_state_descriptor_fputil_internal_X87StateDescriptor.Invoke(&fputil_internal_X87StateDescriptor2);
			num = fputil_internal_get_mxcsr.Invoke();
			int num3 = (ushort)num2;
			short* ptr2 = &fputil_internal_X87StateDescriptor2.status_word;
			*ptr2 = (short)((ushort)(*ptr2) | num3);
			num |= (ushort)num2;
			fputil_internal_write_x87_state_descriptor_fputil_internal_X87StateDescriptor_const.Invoke(&fputil_internal_X87StateDescriptor2);
			fputil_internal_write_mxcsr_unsigned_int.Invoke(num);
			fputil_internal_fwait.Invoke();
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(28L, &fputil_internal_X87StateDescriptor2);
		}
	}
}
